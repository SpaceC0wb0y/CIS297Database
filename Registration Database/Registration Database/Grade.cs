//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Registration_Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grade
    {
        public int Id { get; set; }
        public int A_Grade { get; set; }
        public int Aminus_Grade { get; set; }
        public int Bplus_Grade { get; set; }
        public int B_Grade { get; set; }
        public int Bminus__Grade { get; set; }
        public int Cplus__Grade { get; set; }
        public int C_Grade { get; set; }
        public int Cminus__Grade { get; set; }
        public int F_Grade { get; set; }
        public int Section_Id { get; set; }
    
        public virtual Section Section { get; set; }
    }
}
