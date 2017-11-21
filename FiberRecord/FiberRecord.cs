using System;

namespace FiberRecordNS
{
    /// <summary>
    /// 光纤记录类，在Excel中存储的数据，最后都被解析为FiberRecord类的数据
    /// </summary>

    [Serializable]
    public class FiberRecord
    {

        /// <summary>
        /// 尾纤标记,可作为每条光纤数据的身份标记关键字
        /// </summary>
        public string FiberPigtail;
        
        /// <summary>
        /// 光纤所属运营商
        /// 目前合作的运营商：电信、联通、移动、中信
        /// </summary>
        public string TeleOperator;
        
        /// <summary>
        /// 光纤的卡口业务应用：1---使用;  2---未使用
        /// </summary>
        public string BayonetUsed;

        /// <summary>
        /// 光纤的视频专网业务应用：1---使用;  2---未使用
        /// </summary>
        public string VideoUsed;

        /// <summary>
        /// 光纤的监控系统业务应用：1---使用; 2---未使用
        /// </summary>
        public string MonitorUsed;

        /// <summary>
        /// 光纤的电子警察业务应用：1---使用; 2---未使用
        /// </summary>
        public string EPoliceUsed;

        /// <summary>
        /// 光纤的信号机业务应用：1---使用; 2---未使用
        /// </summary>
        public string SignalUsed;

        /// <summary>
        /// 光纤的交通诱导业务应用：1---使用; 2---未使用
        /// </summary>
        public string TrafficGuidanceUsed;

         /// <summary>
         /// 光纤的内网业务应用：1---使用; 2---未使用
         /// </summary>
         public string IntranetUsed;

        /// <summary>
        /// 光纤部署的路口位置描述
        /// </summary>
        public string RoadCross;
        /// <summary>
        /// 光纤在支队11楼机柜上的部署位置
        /// 例子：GL1柜一框A盘01# 
        /// GL1：柜号（1-4），一框:框号（从上至下，一到五）； A盘：盘号（A-F）01#：芯号（1-12） 
        /// </summary>
        public string DetachmentLocationA;

        /// <summary>
        /// 光纤在支队12楼机柜上的部署位置
        /// </summary>
        public string DetachmentLocationB;

        /// <summary>
        /// 光纤在远程路口的的部署情况(路口A)，其维护由光纤运营商负责
        /// </summary>
        public string RemoteLocationA;

        /// <summary>
        /// 光纤在远程路口的的部署情况(路口B)，其维护由光纤运营商负责
        /// </summary>
        public string RemoteLocationB;

        /// <summary>
        /// 光纤介入类型，主要包括：SC、FC、LC、ST
        /// </summary>
        public string FiberPlugType;

        /// <summary>
        /// 光纤合同编号
        /// </summary>
        public string ContractIndex;

        /// <summary>
        /// 表示当前数据记录状态
        /// 0x00--未变化 0x01 ---删除，0x10---新增, 0x11---编辑
        /// 初始化的时候，该值==0x00
        /// </summary>
        public int EditFlag;

        public FiberRecord()
        {
            EditFlag = 0x00;
        }

    }



    [Serializable]
    /// <summary>
    /// 光纤合同类
    /// </summary>
    public class FiberContract
    {
        /// <summary>
        /// 合同编号
        /// </summary>
        public string ContractIndex;

        /// <summary>
        /// 光纤合同的起始时间
        /// </summary>
        public string ContractStartDate;

        /// <summary>
        /// 光纤合同的结束时间
        /// </summary>
        public string ContractEndDate;

        /// <summary>
        /// 光纤合同的描述信息
        /// </summary>
        public string Description;
    }
}
