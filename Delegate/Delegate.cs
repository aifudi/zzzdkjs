using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiberRecordNS;

namespace DelegateNS
{

    /// <summary>
    /// 委托定义
    /// </summary>
    public  static class Delegate
    {
        // 定义编辑光纤记录回调函数
        public  delegate void EditFiberRecHandle(FiberRecord newrec);

        // 定义增加光纤记录回调函数
        public delegate void AddFiberRecHandle(FiberRecord rec);

        // 定义删除光纤记录回调函数
        public delegate void DelFiberRecHandle(FiberRecord rec);

    }
}
