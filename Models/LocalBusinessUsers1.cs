//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GAG_101.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LocalBusinessUsers1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LocalBusinessUsers1()
        {
            this.UserReviews1 = new HashSet<UserReviews1>();
        }
    
        public int LocalBusiness_ID { get; set; }
        public string LocalBusiness_UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Business_Name { get; set; }
        public string BU_FEIN { get; set; }
        public Nullable<int> Location_Zip { get; set; }
        public string Phone_Number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserReviews1> UserReviews1 { get; set; }
    }
}
