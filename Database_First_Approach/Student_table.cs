//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database_First_Approach
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student_table
    {
        public int Std_id { get; set; }
        public string Std_name { get; set; }
        public Nullable<int> dep_id { get; set; }
    
        public virtual Department_table Department_table { get; set; }
    }
}
