//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerAccount
    {
        public int ProcessID { get; set; }
        public string LastAcount { get; set; }
        public string EntryDate { get; set; }
        public string ExitDate { get; set; }
        public Nullable<int> PeopleNumber { get; set; }
        public Nullable<int> RoomID { get; set; }
        public Nullable<int> CustomerID { get; set; }
    
        public virtual CustomerRegi CustomerRegi { get; set; }
        public virtual Room Room { get; set; }
    }
}
