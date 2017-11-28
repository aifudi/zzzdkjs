using System.Collections.Generic;
using FiberRecordNS;

namespace IDataParseNS
{
    /// <summary>
    ///  处理光纤数据记录的类接口。由于可以采用Excel、XML以及数据库进行记录保存
    ///  不同的文件保存方式有不同的处理操作方法，因此定义此接口
    /// </summary>
    public interface IDataParse
    {
        /// <summary>
        /// 删除光纤数据记录
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        bool DelRecord(FiberRecord rec);

        /// <summary>
        /// 新增光纤数据记录
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        bool AddNewRecord(FiberRecord rec);

        /// <summary>
        /// 编辑光纤记录
        /// </summary>
        /// <param name="oldrec"></param>
        /// <param name="newrec"></param>
        /// <returns></returns>
        bool EditRecord(FiberRecord newrec);

        /// <summary>
        /// 返回不同业务使用的光纤线路
        /// 目前支持的业务包括：卡口、监控系统、电子警察等
        /// </summary>
        /// <returns></returns>
        Dictionary<string, int> GetDataStatisticsByUsing();
        
        /// <summary>
        /// 返回不同运营商负责承建维护的光纤线路
        /// </summary>
        /// <returns></returns>
        Dictionary<string, int> GetDataStatisticsByTeleOperator();

        /// <summary>
        /// 初始化光纤记录数据集（从后台数据文件中读取）
        /// </summary>
        /// <param name="hasTitle"></param>
        /// <returns></returns>
        List<FiberRecord> InitFiberRecordsData(bool hasTitle = true);


        /// <summary>
        /// 返回光纤记录数据集（进行编辑、删除、添加操作后的数据记录集合）
        /// </summary>
        /// <param name="hasTitle"></param>
        /// <returns></returns>
        List<FiberRecord> GetFiberRecordsData();


        /// <summary>
        /// 更新数据记录
        /// </summary>
        /// <param name="rec"></param>
        void UpdateFiberRecords(FiberRecord rec);


        /// <summary>
        /// 更新数据记录(针对编辑操作)
        /// </summary>
        /// <param name="rec"></param>
        void UpdateFiberRecords(FiberRecord oldrec,FiberRecord rec);

        /// <summary>
        /// 返回所有交叉路口的名称
        /// </summary>
        /// <param name="records"></param>
        /// <returns></returns>
        List<string> GetDataStatisticsByRoadCrossName();

        /// <summary>
        /// 返回路段名称数据集合
        /// </summary>
        /// <returns></returns>
        List<string> GetDataStatisticsByRoadName();

        /// <summary>
        /// 保存数据记录至后台文件
        /// </summary>
        void SaveRecordToFile();

    }
}
