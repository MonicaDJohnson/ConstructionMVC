//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConstructionMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class House
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public House()
        {
            this.Types = new HashSet<Type>();
        }
    
        public int Location_HouseID { get; set; }
        public string Rooms { get; set; }
        public string Floors { get; set; }
        public Nullable<bool> IsGarage { get; set; }
        public string BuildDate { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> LocationID { get; set; }
    
        public virtual Location Location { get; set; }
        public virtual Location Location1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Type> Types { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
