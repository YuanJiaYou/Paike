//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BanJiBiao
    {
        public int ID { get; set; }
        public string BanJiMing { get; set; }
        public Nullable<int> BanJiRenShu { get; set; }
        public Nullable<System.DateTime> KaiBanShiJian { get; set; }
        public string BeiZhu { get; set; }
        public Nullable<System.DateTime> YuJiJieShuShiJian { get; set; }
        public Nullable<int> BanJiZhuangTai { get; set; }
        public Nullable<int> JieDuanID { get; set; }
        public Nullable<bool> JiaoXuePlan { get; set; }
    }
}
