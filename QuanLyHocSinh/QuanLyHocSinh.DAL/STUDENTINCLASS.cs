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
    
    public partial class STUDENTINCLASS
    {
        public string SCHOOLYEARID { get; set; }
        public string IDCLASS { get; set; }
        public string MSHOCSINH { get; set; }
    
        public virtual CLASS CLASS { get; set; }
        public virtual SCHOOLYEAR SCHOOLYEAR { get; set; }
        public virtual STUDENT STUDENT { get; set; }
    }
}
