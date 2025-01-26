//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirportDispatcher.Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flights
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flights()
        {
            this.TicketsSelling = new HashSet<TicketsSelling>();
        }
    
        public int IdFlight { get; set; }
        public string FlightNumber { get; set; }
        public int IdAirlane { get; set; }
        public int AirportDeparturesId { get; set; }
        public int ArrivalAirportId { get; set; }
        public System.DateTime DepartureDate { get; set; }
        public System.TimeSpan DepartureTime { get; set; }
        public int TotalSeatsFree { get; set; }
        public int IdStatus { get; set; }
        public int IdAirplane { get; set; }
        public Nullable<int> IdGate { get; set; }
    
        public virtual Airlines Airlines { get; set; }
        public virtual Airplane Airplane { get; set; }
        public virtual Airports Airports { get; set; }
        public virtual Airports Airports1 { get; set; }
        public virtual Gates Gates { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TicketsSelling> TicketsSelling { get; set; }
    }
}
