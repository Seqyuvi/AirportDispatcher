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
    
    public partial class Airlines
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Airlines()
        {
            this.Flights = new HashSet<Flights>();
        }
    
        public int IdAirline { get; set; }
        public string TitleAirlane { get; set; }
        public string CodeAirline { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flights> Flights { get; set; }
    }
}
