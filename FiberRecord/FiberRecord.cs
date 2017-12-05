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
        public string FiberPigtail { get; set; }
        
        /// <summary>
        /// 光纤所属运营商
        /// 目前合作的运营商：电信、联通、移动、中信
        /// </summary>
        public string TeleOperator { get; set; }

        /// <summary>
        /// 光纤的卡口业务应用：1---使用;  2---未使用
        /// </summary>
        public string BayonetUsed { get; set; }

        /// <summary>
        /// 光纤的视频专网业务应用：1---使用;  2---未使用
        /// </summary>
        public string VideoUsed { get; set; }

        /// <summary>
        /// 光纤的监控系统业务应用：1---使用; 2---未使用
        /// </summary>
        public string MonitorUsed { get; set; }

        /// <summary>
        /// 光纤的电子警察业务应用：1---使用; 2---未使用
        /// </summary>
        public string EPoliceUsed { get; set; }

        /// <summary>
        /// 光纤的信号机业务应用：1---使用; 2---未使用
        /// </summary>
        public string SignalUsed { get; set; }

        /// <summary>
        /// 光纤的交通诱导业务应用：1---使用; 2---未使用
        /// </summary>
        public string TrafficGuidanceUsed { get; set; }

        /// <summary>
        /// 光纤的内网业务应用：1---使用; 2---未使用
        /// </summary>
        public string IntranetUsed { get; set; }

        /// <summary>
        /// 光纤部署的路口位置描述
        /// </summary>
        //public string RoadCross;
        public RoadCrossInfo roadcrossinfo { get; set; }

        /// <summary>
        /// 光纤在支队11楼机柜上的部署位置
        /// 例子：GL1柜一框A盘01# 
        /// GL1：柜号（1-4），一框:框号（从上至下，一到五）； A盘：盘号（A-F）01#：芯号（1-12） 
        /// </summary>
        public string DetachmentLocationA { get; set; }

        /// <summary>
        /// 光纤在支队12楼机柜上的部署位置
        /// </summary>
        public string DetachmentLocationB { get; set; }

        /// <summary>
        /// 光纤介入类型，主要包括：SC、FC、LC、ST
        /// </summary>
        public string FiberPlugType { get; set; }

        /// <summary>
        /// 光纤合同编号
        /// </summary>
        public string ContractIndex { get; set; }

        /// <summary>
        /// 表示当前数据记录状态
        /// 0x00--未变化 0x01 ---删除，0x10---新增, 0x11---编辑
        /// 初始化的时候，该值==0x00
        /// </summary>
        public int EditFlag { get; set; }

        /// <summary>
        /// 关于光纤记录的备注信息
        /// </summary>
        public string BackupInfo { get; set; }

        public FiberRecord()
        {
            EditFlag = 0x00;
            roadcrossinfo = new RoadCrossInfo();
            ContractIndex = "NOT";
        }

    }

    [Serializable]
    /// <summary>
    /// 路口信息类
    /// </summary>
    public class RoadCrossInfo
    {
        /// <summary>
        /// 光纤部署位置所属的区域
        /// （目前有五个辖区：芦淞、天元、石峰、荷塘以及云龙）
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// 光纤部署的路口位置描述
        /// </summary>
        public string RoadCrossname { get; set; }

        /// <summary>
        /// 光纤外场部署经度
        /// </summary>
        public double log { get; set; }

        /// <summary>
        /// 光纤外场部署纬度
        /// </summary>
        public double lat { get; set; }
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
        public string ContractIndex { get; set; }

        /// <summary>
        /// 光纤合同的起始时间
        /// </summary>
        public string ContractStartDate { get; set; }

        /// <summary>
        /// 光纤合同的结束时间
        /// </summary>
        public string ContractEndDate { get; set; }

        /// <summary>
        /// 光纤合同的描述信息
        /// </summary>
        public string Description { get; set; }
    }
}
