//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clinic_App.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_PatientImages
    {
        public int ID { get; set; }
        public byte[] image { get; set; }
        public int PatientID { get; set; }
    
        public virtual Tbl_Patient Tbl_Patient { get; set; }
    }
}
