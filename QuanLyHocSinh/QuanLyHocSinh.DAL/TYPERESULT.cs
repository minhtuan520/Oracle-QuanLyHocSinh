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
    
    public partial class TYPERESULT
    {
        public TYPERESULT()
        {
            this.LEARNINGOUTCOMES = new HashSet<LEARNINGOUTCOMES>();
        }
    
        public string TYPERESULTID { get; set; }
        public string NAME { get; set; }
    
        public virtual ICollection<LEARNINGOUTCOMES> LEARNINGOUTCOMES { get; set; }
    }
}
