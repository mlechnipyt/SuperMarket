//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuperMarketer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Merchandise
    {
        public int MerchID { get; set; }
        public int StoreID { get; set; }
        public int VendorID { get; set; }
        public string MerchName { get; set; }
        public Nullable<decimal> MerchPrice { get; set; }
        public Nullable<long> BarCode { get; set; }
        public Nullable<decimal> PromotionPrice { get; set; }
        public Nullable<System.DateTime> PromotionDateS { get; set; }
        public Nullable<System.DateTime> PromotionDateE { get; set; }
    
        public virtual ChainStore ChainStore { get; set; }
        public virtual Consume Consume { get; set; }
        public virtual Inventory Inventory { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
