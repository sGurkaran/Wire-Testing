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
    
    public partial class tb_Reports
    {
        public tb_Reports()
        {
            this.tb_ValuesOfReport_Lists = new HashSet<tb_ValuesOfReport_Lists>();
            this.tb_ValuesOfReports = new HashSet<tb_ValuesOfReports>();
        }
    
        public int ID { get; set; }
        public string ReportName { get; set; }
        public string Result { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Status { get; set; }
        public Nullable<int> Enable { get; set; }
        public string Customer { get; set; }
        public string OtherSpec { get; set; }
        public Nullable<System.DateTime> InvDate { get; set; }
        public string Qty { get; set; }
        public string Winding { get; set; }
        public string Surface { get; set; }
        public string Edge { get; set; }
        public string Polythene { get; set; }
        public string Box { get; set; }
        public string Wrapper { get; set; }
        public string Trace { get; set; }
        public string Weight { get; set; }
        public string Size { get; set; }
        public string Cover { get; set; }
        public string InvNo { get; set; }
        public string Clean { get; set; }
    
        public virtual tb_Product tb_Product { get; set; }
        public virtual ICollection<tb_ValuesOfReport_Lists> tb_ValuesOfReport_Lists { get; set; }
        public virtual ICollection<tb_ValuesOfReports> tb_ValuesOfReports { get; set; }
    }
}
