//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Implementation.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class TicketStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TicketStatus()
        {
            this.Ticket = new HashSet<Ticket>();
            this.TicketTransition = new HashSet<TicketTransition>();
            this.TicketTransition1 = new HashSet<TicketTransition>();
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public long TicketTypeId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Ticket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TicketTransition> TicketTransition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TicketTransition> TicketTransition1 { get; set; }
        public virtual TicketType TicketType { get; set; }
    }
}
