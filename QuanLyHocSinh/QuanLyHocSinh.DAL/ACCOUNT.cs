//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyHocSinh.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ACCOUNT
    {
        public ACCOUNT()
        {
            this.STUDENT = new HashSet<STUDENT>();
        }
    
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<decimal> IDTYPE { get; set; }
    
        public virtual TYPEACCOUNT TYPEACCOUNT { get; set; }
        public virtual ICollection<STUDENT> STUDENT { get; set; }
    }
}