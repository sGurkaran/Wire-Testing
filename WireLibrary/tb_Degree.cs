//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WireLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Degree
    {
        public tb_Degree()
        {
            this.tb_Product = new HashSet<tb_Product>();
        }
    
        public int ID { get; set; }
        public string Type { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> ModifyBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.TimeSpan> ModifiedTime { get; set; }
        public string Status { get; set; }
        public Nullable<int> Enable { get; set; }
    
        public virtual ICollection<tb_Product> tb_Product { get; set; }
    }
}
