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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grade()
        {
            this.Sections = new HashSet<Section>();
        }
    
        public int Id { get; set; }
        public int A_Grade { get; set; }
        public int A__Grade { get; set; }
        public int B__Grade { get; set; }
        public int B_Grade { get; set; }
        public int B__Grade1 { get; set; }
        public int C__Grade { get; set; }
        public int C_Grade { get; set; }
        public int C__Grade1 { get; set; }
        public int F_Grade { get; set; }
        public int Section_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Section> Sections { get; set; }
        public virtual Section Section { get; set; }
    }
}
