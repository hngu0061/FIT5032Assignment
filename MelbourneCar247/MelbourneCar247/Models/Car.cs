namespace MelbourneCar247.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            Bookings = new HashSet<Booking>();
        }

        public int CarId { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Type { get; set; }

        [Column(TypeName = "date")]
        public DateTime Year { get; set; }

        [Required]
        public string Model { get; set; }

        public double RentalFee { get; set; }

        public int LocationPostcode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
