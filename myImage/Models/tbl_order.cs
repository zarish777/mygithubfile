//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myImage.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_order
    {
        public int order_id { get; set; }
        public int order_no { get; set; }
        public int print_id { get; set; }
        public int qty { get; set; }
        public int cust_id { get; set; }
        public int total_price { get; set; }
        public string payment_method { get; set; }
        public string card_no { get; set; }
        public System.DateTime exp_date { get; set; }
        public int cvv_no { get; set; }
    
        public virtual tbl_register tbl_register { get; set; }
        public virtual tbl_print tbl_print { get; set; }
    }
}