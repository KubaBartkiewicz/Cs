//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP2019
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderCustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderCustomer()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int IdOrderCustomer { get; set; }
        public int IdCustomer { get; set; }
        public int IdEmployee { get; set; }
        public System.DateTime OrderDate { get; set; }
        public decimal Cost { get; set; }
        public double Markup { get; set; }
        public Nullable<bool> NewOrderInfo { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
