//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sperience
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubjectNote
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string SubjectNote1 { get; set; }
        public int CompanyId { get; set; }
        public int LocationId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int Createdby { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> Updatedby { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<int> Deletedby { get; set; }
    
        public virtual SubjectHeader SubjectHeader { get; set; }
    }
}
