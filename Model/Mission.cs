//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mission
    {
        public int mission_id { get; set; }
        public string mission_name { get; set; }
        public string type { get; set; }
        public Nullable<int> Fk_group_id { get; set; }
    
        public virtual Group Group { get; set; }
    }
}
