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
    
    public partial class XueShengBiao
    {
        public int ID { get; set; }
        public string StudentName { get; set; }
        public Nullable<int> StudentClassID { get; set; }
        public Nullable<bool> Sex { get; set; }
        public Nullable<int> Age { get; set; }
        public string MiMa { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string HomePhone { get; set; }
        public Nullable<int> ZhuangTai { get; set; }
    }
}
