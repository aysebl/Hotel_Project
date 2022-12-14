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
    
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            this.CustomerAccounts = new HashSet<CustomerAccount>();
        }
    
        public int RoomID { get; set; }
        public Nullable<int> RoomPrice { get; set; }
        public Nullable<int> BedCount { get; set; }
        public string RoomType { get; set; }
        public Nullable<int> ServiceID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerAccount> CustomerAccounts { get; set; }
        public virtual Service Service { get; set; }
    }
}
