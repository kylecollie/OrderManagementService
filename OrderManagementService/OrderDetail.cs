//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderManagementService
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public string Order_Detail_No { get; set; }
        public string Order_No { get; set; }
        public string Item_Name { get; set; }
        public string Notes { get; set; }
        public int QTY { get; set; }
        public int Price { get; set; }
    
        public virtual OrderMaster OrderMaster { get; set; }
    }
}
