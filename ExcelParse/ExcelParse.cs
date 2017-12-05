using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using FiberRecordNS;
using IDataParseNS;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelParseNS
{
    /// <summary>
    /// 解析Excel文件的类，主要完成Excel文件的读取、写入等操作
    /// </summary>
    public class ExcelParse : IDataParse
    {

        private string excelFilePath = string.Empty;
        public DataTable dt;
        private List<FiberRecord> fiberrecords = new List<FiberRecord>();
        private List<string> roadnamelist = new List<string>();

        private List<string> crossnamelist = new List<string>();

        // 不同业务使用的光纤线路统计字典
        private Dictionary<string, int> numberoftaskusingdict = new Dictionary<string, int>();

        // 不同运营商使用的光纤数目统计字典
        private Dictionary<string, int> numberofoperatordict = new Dictionary<string, int>();


        public ExcelParse(string _filename)
        {
            excelFilePath = _filename;
            dt = new DataTable();
            DataInit();
        }

        public ExcelParse()
        {
            dt = new DataTable();
        }

        /// <summary>
        /// Excel数据记录文件的初始化
        /// </summary>
        private void DataInit()
        {

            InitFiberRecordsData(true);
            numberoftaskusingdict = GetDataStatisticsByUsing();
            numberofoperatordict = GetDataStatisticsByTeleOperator();
            roadnamelist = GetDataStatisticsByRoadName();
            crossnamelist = GetDataStatisticsByRoadCrossName();
        }

        /// <summary>
        /// 返回以FiberRecord类结构保存的数据记录
        /// </summary>
        /// <returns></returns>
        public FiberRecord ParseDataRow(DataRow row)
        {
            var record = new FiberRecord();
            foreach (DataColumn column in dt.Columns)
            {
                switch (column.ColumnName.Trim())
                {
                    case "序号":

                        break;
                    case "运营商":
                        record.TeleOperator = row[column].ToString();
                        break;
                    case "光纤尾号":
                        record.FiberPigtail = row[column].ToString();
                        break;
                    case "外场地址":
                        string str = row[column].ToString();
                        record.roadcrossinfo.RoadCrossname = str;
                        break;
                    case "电视监视":
                        record.MonitorUsed = row[column].ToString();
                        break;
                    case "电警":
                        record.EPoliceUsed = row[column].ToString();
                        break;
                    case "卡口":
                        record.BayonetUsed = row[column].ToString();
                        break;
                    case "信号":
                        record.SignalUsed = row[column].ToString();
                        break;
                    case "交通诱导":
                        record.TrafficGuidanceUsed = row[column].ToString();
                        break;
                    case "内网":
                        record.IntranetUsed = row[column].ToString();
                        break;
                    case "视频专网":
                        record.VideoUsed = row[column].ToString();
                        break;
                    case "十一楼机房位置":
                        record.DetachmentLocationA = row[column].ToString();
                        break;
                    case "十二楼机房位置":
                        record.DetachmentLocationB = row[column].ToString();
                        break;
                    case "行政区域":
                        record.roadcrossinfo.District = row[column].ToString();
                        break;
                    case "备注信息":
                        record.BackupInfo = row[column].ToString();
                        break;

                }

            }
            return record;
        }

        /// <summary>
        /// 返回不同业务使用的光纤线路
        /// 目前支持的业务包括：卡口、监控系统、电子警察等
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetDataStatisticsByUsing()
        {
            var result = new Dictionary<string, int>();
            string[] strs = new string[] { "卡口", "电子警察", "视频专网", "电视监视", "信号", "内网" };
            List<string> list = strs.ToList<string>();

            for (int i = 0; i < list.Count; i++)
            {
                result.Add(list[i], 0);
            }

            foreach (FiberRecord rec in fiberrecords)
            {
                if (rec.EditFlag == 0x01)
                {
                    continue;
                }

                if (string.Compare(rec.EPoliceUsed, "有") == 0)
                {
                    result["电子警察"]++;
                }

                if (string.Compare(rec.BayonetUsed, "有") == 0)
                {
                    result["卡口"]++;
                }
                if (string.Compare(rec.MonitorUsed, "有") == 0)
                {
                    result["电视监视"]++;
                }

                if (string.Compare(rec.SignalUsed, "有") == 0)
                {
                    result["信号"]++;
                }

                if (string.Compare(rec.VideoUsed, "有") == 0)
                {
                    result["视频专网"]++;
                }

                if (string.Compare(rec.IntranetUsed, "有") == 0)
                {
                    result["内网"]++;
                }

            }
            return result;
        }

        /// <summary>
        /// 返回不同运营商负责承建维护的光纤线路
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetDataStatisticsByTeleOperator()
        {
            var result = new Dictionary<string, int>();
            foreach (FiberRecord rec in fiberrecords)
            {
                if (rec.EditFlag ==0x01)
                {
                    continue;
                }
                string keyname = rec.TeleOperator;
                if (result.ContainsKey(keyname))
                {
                    result[keyname]++;
                }

                else
                {
                    result.Add(keyname, 1);
                }
            }
            return result;
        }

        /// <summary>
        /// 返回路段名称数据集合
        /// </summary>
        /// <returns></returns>
        public List<string> GetDataStatisticsByRoadName()
        {
            var result = new List<string>();
            string stra = string.Empty;
            string strb = string.Empty;
            foreach (FiberRecord rec in fiberrecords)
            {
                string str = rec.roadcrossinfo.RoadCrossname;
                if (str.Contains('－'))
                {
                    // 将外场地址拆分为两个路口
                    string[] addrs = str.Split('－');
                    stra = addrs[0].Trim();
                    strb = addrs[1].Trim();
                }
                else
                {
                    if (str.Contains('-'))
                    {
                        string[] addrs = str.Split('-');
                        stra = addrs[0].Trim();
                        strb = addrs[1].Trim();
                    }
                    else
                    {
                        stra = str;
                        strb = str;
                    }
                }
                if (!result.Contains(stra) && stra != string.Empty)
                {
                    result.Add(stra);
                }
                if (!result.Contains(strb) && strb != string.Empty)
                {
                    result.Add(strb);
                }
            }
            return result;
        }


        /// <summary>
        /// 返回所有的路口名称
        /// </summary>
        /// <returns></returns>
        public List<string> GetDataStatisticsByRoadCrossName()
        {
            var result = new List<string>();
            foreach (FiberRecord rec in fiberrecords)
            {
                result.Add(rec.roadcrossinfo.RoadCrossname);
            }
            return result;
        }

        /// <summary>
        /// 检查数据的有效性
        /// </summary>
        /// <returns></returns>
        private bool CheckDataValidity()
        {
            return false;
        }

        /// <summary>
        /// 编辑选中的光纤记录，采用的方法是先删除旧的记录，再添加新的光纤维护记录
        /// </summary>
        /// <returns></returns>
        public bool EditRecord(FiberRecord newrec)
        {
            bool result1 = DelRecord(newrec);
            bool result2 = AddNewRecord(newrec);
            return result1 && result2;
        }

        /// <summary>
        /// 从Excel文件中删除选中的光纤记录
        /// </summary>
        /// <param name="rec"></param>
        /// <returns>false:未能成功删除记录;true:成功删除记录</returns>
        public bool DelRecord(FiberRecord rec)
        {

            bool result = true;
            Excel.Application app = new Excel.Application();
            app.DisplayAlerts = false;
            Excel.Sheets sheets;
            Excel.Workbook workbook = null;
            object oMissiong = System.Reflection.Missing.Value;
            try
            {
                workbook = app.Workbooks.Open(excelFilePath, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong,
                    oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong);
                sheets = workbook.Worksheets;
                Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1); //读取第一张表  
                if (worksheet == null)
                    return false;
                Excel.Range range;
                int delrow = -1;
                int pigtailcol = -1;
                int iRowCount = worksheet.UsedRange.Rows.Count;
                int iColCount = worksheet.UsedRange.Columns.Count;
                // 首先确定“光纤尾号”是在哪一列
                for (int iCol = 1; iCol <= iColCount; iCol++)
                {
                    string txt2 = ((Excel.Range)worksheet.Cells[1, iCol]).Text.ToString();

                    if (string.Compare(txt2.Trim(), "光纤尾号") == 0)
                    {
                        pigtailcol = iCol;
                        break;
                    }
                }
                // 再判断当前要删除的记录在哪一行
                for (int i = 2; i <= iRowCount; i++)
                {
                    string pigtaildel = rec.FiberPigtail;
                    string txt = ((Excel.Range)worksheet.Cells[i, pigtailcol]).Value2.ToString();
                    if (string.Compare(txt, pigtaildel) == 0)
                    {
                        delrow = i;
                        break;
                    }
                }
                // 未找到记录
                if (delrow == -1)
                {
                    MessageBox.Show("删除的光纤维护记录有误，请确认！");
                    result = false;
                }
                if (delrow > 0)
                {
                    range = (Excel.Range)worksheet.Rows[delrow, oMissiong];
                    range.Delete(Excel.XlDeleteShiftDirection.xlShiftUp);
                    workbook.SaveAs(excelFilePath, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                        Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value,
                        Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                }
            }
            catch
            {
                result = false;
            }
            finally
            {
                workbook.Close(false, oMissiong, oMissiong);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                workbook = null;
                app.Workbooks.Close();
                app.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                app = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            return result;
        }

        /// <summary>
        /// 向Excel文件中添加纪录
        /// </summary>
        /// <returns></returns>
        public bool AddNewRecord(FiberRecord rec)
        {
            Excel.Application app = new Excel.Application();
            Excel.Sheets sheets;
            object oMissiong = System.Reflection.Missing.Value;
            Excel.Workbook workbook = null;

            try
            {
                if (app == null) return false;
                app.DisplayAlerts = false;
                workbook = app.Workbooks.Open(excelFilePath, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong,
                    oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong);
                sheets = workbook.Worksheets;

                //将数据读入到DataTable中
                Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1); //读取第一张表  
                if (worksheet == null) return false;

                int iRowCount = worksheet.UsedRange.Rows.Count;
                int iColCount = worksheet.UsedRange.Columns.Count;

                //将数据记录添加到最后一行
                int rowIdx = iRowCount + 1;
                for (int iCol = 1; iCol <= iColCount; iCol++)
                {
                    string txt2 = ((Excel.Range)worksheet.Cells[1, iCol]).Text.ToString();

                    switch (txt2)
                    {
                        case "序号":
                            worksheet.Cells[rowIdx, iCol] = rowIdx.ToString(); //光纤承建运营商
                            break;
                        case "运营商":
                            worksheet.Cells[rowIdx, iCol] = rec.TeleOperator; //服务提供运营商
                            break;
                        case "光纤尾号":
                            worksheet.Cells[rowIdx, iCol] = rec.FiberPigtail; //尾纤编号
                            break;
                        case "外场地址":
                            worksheet.Cells[rowIdx, iCol] = rec.DetachmentLocationB; //外场地址
                            break;
                        case "电视监视":
                            worksheet.Cells[rowIdx, iCol] = rec.MonitorUsed; //光纤承建运营商
                            break;
                        case "电警":
                            worksheet.Cells[rowIdx, iCol] = rec.EPoliceUsed; //服务提供运营商
                            break;
                        case "卡口":
                            worksheet.Cells[rowIdx, iCol] = rec.BayonetUsed; //尾纤编号
                            break;
                        case "信号":
                            worksheet.Cells[rowIdx, iCol] = rec.SignalUsed; //外场地址
                            break;
                        case "内网":
                            worksheet.Cells[rowIdx, iCol] = rec.IntranetUsed; //光纤承建运营商
                            break;
                        case "视频专网":
                            worksheet.Cells[rowIdx, iCol] = rec.VideoUsed; //服务提供运营商
                            break;
                        case "十一楼机房位置":
                            worksheet.Cells[rowIdx, iCol] = rec.DetachmentLocationA; //尾纤编号
                            break;
                        case "十二楼机房位置":
                            worksheet.Cells[rowIdx, iCol] = rec.DetachmentLocationB; //外场地址
                            break;
                    }

                }
                workbook.SaveAs(excelFilePath, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value,
                    Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            }
            catch
            {
                return false;
            }
            finally
            {
                workbook.Close(false, oMissiong, oMissiong);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                workbook = null;
                app.Workbooks.Close();
                app.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                app = null;

            }
            return true;
        }



        /// <summary>
        /// 采用COM组件的方式从excel文件中读取数据,并以List<FiberRecord>的格式返回
        /// </summary>
        /// <param name="hasTitle"></param>
        /// <returns></returns>
        public List<FiberRecord> InitFiberRecordsData(bool hasTitle = true)
        {
            Excel.Application app = new Excel.Application();
            Excel.Sheets sheets;
            object oMissiong = System.Reflection.Missing.Value;
            Excel.Workbook workbook = null;
            try
            {
                if (app == null) return null;
                workbook = app.Workbooks.Open(excelFilePath, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong,
                    oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong);
                sheets = workbook.Worksheets;

                //将数据读入到DataTable中
                Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1); //读取第一张表  
                if (worksheet == null) return null;

                int iRowCount = worksheet.UsedRange.Rows.Count;
                int iColCount = worksheet.UsedRange.Columns.Count;
                //生成列头
                for (int i = 0; i < iColCount; i++)
                {
                    var name = "column" + i;
                    if (hasTitle)
                    {
                        var txt = ((Excel.Range)worksheet.Cells[1, i + 1]).Text.ToString();
                        if (!string.IsNullOrWhiteSpace(txt)) name = txt;
                    }
                    while (dt.Columns.Contains(name)) name = name + "_1"; //重复行名称会报错。
                    dt.Columns.Add(new DataColumn(name, typeof(string)));
                }
                //生成行数据
                Excel.Range range;
                int rowIdx = hasTitle ? 2 : 1;
                for (int iRow = rowIdx; iRow <= iRowCount; iRow++)
                {
                    DataRow dr = dt.NewRow();
                    for (int iCol = 1; iCol <= iColCount; iCol++)
                    {
                        range = (Excel.Range)worksheet.Cells[iRow, iCol];
                        dr[iCol - 1] = (range.Value2 == null) ? "" : range.Text.ToString();
                    }

                    dt.Rows.Add(dr);
                }

                //var records = new List<FiberRecord>();
                foreach (DataRow row in dt.Rows)
                {
                    var record = ParseDataRow(row);
                    fiberrecords.Add(record);
                }
                return fiberrecords;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                workbook.Close(false, oMissiong, oMissiong);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                workbook = null;
                app.Workbooks.Close();
                app.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                app = null;
            }
        }

        //        /// <summary>  
        //        /// 使用COM，多线程读取Excel（1 主线程、4 副线程）  
        //        /// </summary>  
        //        /// <param name="excelFilePath">路径</param>  
        //        /// <returns>DataTabel</returns>  
        //        public System.Data.DataTable ThreadReadExcel(string excelFilePath)
        //        {
        //            Excel.Application app = new Excel.Application();
        //            Excel.Sheets sheets = null;
        //            Excel.Workbook workbook = null;
        //            object oMissiong = System.Reflection.Missing.Value;
        //            System.Data.DataTable dt = new System.Data.DataTable();
        //
        //            try
        //            {
        //                if (app == null)
        //                {
        //                    return null;
        //                }
        //
        //                workbook = app.Workbooks.Open(excelFilePath, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong,
        //                    oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong);
        //
        //                //将数据读入到DataTable中——Start    
        //                sheets = workbook.Worksheets;
        //                Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);//读取第一张表  
        //                if (worksheet == null)
        //                    return null;
        //
        //                string cellContent;
        //                int iRowCount = worksheet.UsedRange.Rows.Count;
        //                int iColCount = worksheet.UsedRange.Columns.Count;
        //                Excel.Range range;
        //
        //                //负责列头Start  
        //                DataColumn dc;
        //                int ColumnID = 1;
        //                range = (Excel.Range)worksheet.Cells[1, 1];
        //                //while (range.Text.ToString().Trim() != "")  
        //                while (iColCount >= ColumnID)
        //                {
        //                    dc = new DataColumn();
        //                    dc.DataType = System.Type.GetType("System.String");
        //
        //                    string strNewColumnName = range.Text.ToString().Trim();
        //                    if (strNewColumnName.Length == 0) strNewColumnName = "_1";
        //                    //判断列名是否重复  
        //                    for (int i = 1; i < ColumnID; i++)
        //                    {
        //                        if (dt.Columns[i - 1].ColumnName == strNewColumnName)
        //                            strNewColumnName = strNewColumnName + "_1";
        //                    }
        //
        //                    dc.ColumnName = strNewColumnName;
        //                    dt.Columns.Add(dc);
        //
        //                    range = (Excel.Range)worksheet.Cells[1, ++ColumnID];
        //                }
        //                //End  
        //
        //                //数据大于500条，使用多进程进行读取数据  
        //                if (iRowCount - 1 > 500)
        //                {
        //                    //开始多线程读取数据  
        //                    //新建线程  
        //                    int b2 = (iRowCount - 1) / 10;
        //                    DataTable dt1 = new DataTable("dt1");
        //                    dt1 = dt.Clone();
        //                    SheetOptions sheet1thread = new SheetOptions(worksheet, iColCount, 2, b2 + 1, dt1);
        //                    Thread othread1 = new Thread(new ThreadStart(sheet1thread.SheetToDataTable));
        //                    othread1.Start();
        //
        //                    //阻塞 1 毫秒，保证第一个读取 dt1  
        //                    Thread.Sleep(1);
        //
        //                    DataTable dt2 = new DataTable("dt2");
        //                    dt2 = dt.Clone();
        //                    SheetOptions sheet2thread = new SheetOptions(worksheet, iColCount, b2 + 2, b2 * 2 + 1, dt2);
        //                    Thread othread2 = new Thread(new ThreadStart(sheet2thread.SheetToDataTable));
        //                    othread2.Start();
        //
        //                    DataTable dt3 = new DataTable("dt3");
        //                    dt3 = dt.Clone();
        //                    SheetOptions sheet3thread = new SheetOptions(worksheet, iColCount, b2 * 2 + 2, b2 * 3 + 1, dt3);
        //                    Thread othread3 = new Thread(new ThreadStart(sheet3thread.SheetToDataTable));
        //                    othread3.Start();
        //
        //                    DataTable dt4 = new DataTable("dt4");
        //                    dt4 = dt.Clone();
        //                    SheetOptions sheet4thread = new SheetOptions(worksheet, iColCount, b2 * 3 + 2, b2 * 4 + 1, dt4);
        //                    Thread othread4 = new Thread(new ThreadStart(sheet4thread.SheetToDataTable));
        //                    othread4.Start();
        //
        //                    //主线程读取剩余数据  
        //                    for (int iRow = b2 * 4 + 2; iRow <= iRowCount; iRow++)
        //                    {
        //                        DataRow dr = dt.NewRow();
        //                        for (int iCol = 1; iCol <= iColCount; iCol++)
        //                        {
        //                            range = (Excel.Range)worksheet.Cells[iRow, iCol];
        //                            cellContent = (range.Value2 == null) ? "" : range.Text.ToString();
        //                            dr[iCol - 1] = cellContent;
        //                        }
        //                        dt.Rows.Add(dr);
        //                    }
        //
        //                    othread1.Join();
        //                    othread2.Join();
        //                    othread3.Join();
        //                    othread4.Join();
        //
        //                    //将多个线程读取出来的数据追加至 dt1 后面  
        //                    foreach (DataRow dr in dt.Rows)
        //                        dt1.Rows.Add(dr.ItemArray);
        //                    dt.Clear();
        //                    dt.Dispose();
        //
        //                    foreach (DataRow dr in dt2.Rows)
        //                        dt1.Rows.Add(dr.ItemArray);
        //                    dt2.Clear();
        //                    dt2.Dispose();
        //
        //                    foreach (DataRow dr in dt3.Rows)
        //                        dt1.Rows.Add(dr.ItemArray);
        //                    dt3.Clear();
        //                    dt3.Dispose();
        //
        //                    foreach (DataRow dr in dt4.Rows)
        //                        dt1.Rows.Add(dr.ItemArray);
        //                    dt4.Clear();
        //                    dt4.Dispose();
        //
        //                    return dt1;
        //                }
        //                else
        //                {
        //                    for (int iRow = 2; iRow <= iRowCount; iRow++)
        //                    {
        //                        DataRow dr = dt.NewRow();
        //                        for (int iCol = 1; iCol <= iColCount; iCol++)
        //                        {
        //                            range = (Excel.Range)worksheet.Cells[iRow, iCol];
        //                            cellContent = (range.Value2 == null) ? "" : range.Text.ToString();
        //                            dr[iCol - 1] = cellContent;
        //                        }
        //                        dt.Rows.Add(dr);
        //                    }
        //                }
        //                //将数据读入到DataTable中——End  
        //                return dt;
        //            }
        //            catch
        //            {
        //                return null;
        //            }
        //            finally
        //            {
        //                workbook.Close(false, oMissiong, oMissiong);
        //                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
        //                System.Runtime.InteropServices.Marshal.ReleaseComObject(sheets);
        //                workbook = null;
        //                app.Workbooks.Close();
        //                app.Quit();
        //                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
        //                app = null;
        //                GC.Collect();
        //                GC.WaitForPendingFinalizers();
        //            }
        //        }

        /// <summary>  
        /// 删除Excel行  
        /// </summary>  
        /// <param name="excelFilePath">Excel路径</param>  
        /// <param name="rowStart">开始行</param>  
        /// <param name="rowEnd">结束行</param>  
        /// <param name="designationRow">指定行</param>  
        /// <returns></returns>  
        public string DeleteRows(string excelFilePath, int rowStart, int rowEnd, int designationRow)
        {
            string result = "";
            Excel.Application app = new Excel.Application();
            Excel.Sheets sheets;
            Excel.Workbook workbook = null;
            object oMissiong = System.Reflection.Missing.Value;
            try
            {
                if (app == null)
                {
                    return "分段读取Excel失败";
                }

                workbook = app.Workbooks.Open(excelFilePath, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong,
                    oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong);
                sheets = workbook.Worksheets;
                Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1); //读取第一张表  
                if (worksheet == null)
                    return result;
                Excel.Range range;

                //先删除指定行，一般为列描述  
                if (designationRow != -1)
                {
                    range = (Excel.Range)worksheet.Rows[designationRow, oMissiong];
                    range.Delete(Excel.XlDeleteShiftDirection.xlShiftUp);
                }
                Stopwatch sw = new Stopwatch();
                sw.Start();

                int i = rowStart;
                for (int iRow = rowStart; iRow <= rowEnd; iRow++, i++)
                {
                    range = (Excel.Range)worksheet.Rows[rowStart, oMissiong];
                    range.Delete(Excel.XlDeleteShiftDirection.xlShiftUp);
                }

                sw.Stop();
                TimeSpan ts = sw.Elapsed;
                workbook.Save();

                //将数据读入到DataTable中——End  
                return result;
            }
            catch
            {

                return "分段读取Excel失败";
            }
            finally
            {
                workbook.Close(false, oMissiong, oMissiong);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                workbook = null;
                app.Workbooks.Close();
                app.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                app = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="fileName"></param>
        public void ToExcelSheet(DataSet ds, string fileName)
        {
            Excel.Application appExcel = new Excel.Application();
            Excel.Workbook workbookData = null;
            Excel.Worksheet worksheetData;
            Excel.Range range;
            try
            {
                workbookData = appExcel.Workbooks.Add(System.Reflection.Missing.Value);
                appExcel.DisplayAlerts = false; //不显示警告  
                //xlApp.Visible = true;//excel是否可见  
                //  
                //for (int i = workbookData.Worksheets.Count; i > 0; i--)  
                //{  
                //    Microsoft.Office.Interop.Excel.Worksheet oWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbookData.Worksheets.get_Item(i);  
                //    oWorksheet.Select();  
                //    oWorksheet.Delete();  
                //}  

                for (int k = 0; k < ds.Tables.Count; k++)
                {
                    worksheetData = (Excel.Worksheet)workbookData.Worksheets.Add(System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value);
                    // testnum--;  
                    if (ds.Tables[k] != null)
                    {
                        worksheetData.Name = ds.Tables[k].TableName;
                        //写入标题  
                        for (int i = 0; i < ds.Tables[k].Columns.Count; i++)
                        {
                            worksheetData.Cells[1, i + 1] = ds.Tables[k].Columns[i].ColumnName;
                            range = (Excel.Range)worksheetData.Cells[1, i + 1];
                            //range.Interior.ColorIndex = 15;  
                            range.Font.Bold = true;
                            range.NumberFormatLocal = "@"; //文本格式  
                            range.EntireColumn.AutoFit(); //自动调整列宽  
                            // range.WrapText = true; //文本自动换行    
                            range.ColumnWidth = 15;
                        }
                        //写入数值  
                        for (int r = 0; r < ds.Tables[k].Rows.Count; r++)
                        {
                            for (int i = 0; i < ds.Tables[k].Columns.Count; i++)
                            {
                                worksheetData.Cells[r + 2, i + 1] = ds.Tables[k].Rows[r][i];
                                //Range myrange = worksheetData.get_Range(worksheetData.Cells[r + 2, i + 1], worksheetData.Cells[r + 3, i + 2]);  
                                //myrange.NumberFormatLocal = "@";//文本格式  
                                //// myrange.EntireColumn.AutoFit();//自动调整列宽  
                                ////   myrange.WrapText = true; //文本自动换行    
                                //myrange.ColumnWidth = 15;  
                            }
                            //  rowRead++;  
                            //System.Windows.Forms.Application.DoEvents();  
                        }
                    }
                    worksheetData.Columns.EntireColumn.AutoFit();
                    workbookData.Saved = true;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                workbookData.SaveCopyAs(fileName);
                workbookData.Close(false, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                appExcel.Quit();
                GC.Collect();
            }
        }

        /// <summary>
        /// 更新数据记录
        /// </summary>
        /// <param name="rec"></param>
        public void UpdateFiberRecords(FiberRecord rec)
        {
            switch (rec.EditFlag)
            {
                //case 0x01: // 删除光纤数据记录
                //    fiberrecords.Remove(rec);
                //    break;
                case 0x10: // 新增光纤记录
                    fiberrecords.Add(rec);
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void SaveRecordToFile()
        {
            for (int i = 0; i < fiberrecords.Count; i++)
            {
                switch (fiberrecords[i].EditFlag & 0xFF)
                {
                    case 0x00:  // 未改变
                        break;
                    case 0x01:  // 删除
                        DelRecord(fiberrecords[i]);
                        break;
                    case 0x10:  // 新增
                        AddNewRecord(fiberrecords[i]);
                        break;
                        //case 0x11:  // 编辑
                        //   编辑记录分解为删除和添加两个操作
                        //    
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="oldrec"></param>
        /// <param name="rec"></param>
        public void UpdateFiberRecords(FiberRecord oldrec, FiberRecord rec)
        {
            int index = -1;
            for (int i = 0; i < fiberrecords.Count; i++)
            {
                if (string.Compare(oldrec.FiberPigtail, fiberrecords[i].FiberPigtail) == 0)
                {
                    fiberrecords[i].EditFlag = 0x01;
                    break;
                }
            }

            rec.EditFlag = 0x10;
            fiberrecords.Add(rec);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<FiberRecord> GetFiberRecordsData()
        {
            List<FiberRecord> recs = new List<FiberRecord>();
            for (int i = 0; i < fiberrecords.Count; i++)
            {
                if (fiberrecords[i].EditFlag == 0x01)
                {
                    continue;
                }

                recs.Add(fiberrecords[i]);
            }

            return recs;
        }
    }

}
