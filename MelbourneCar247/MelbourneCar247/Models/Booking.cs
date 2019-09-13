namespace MelbourneCar247.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            Reviews = new HashSet<Review>();
        }

        public int BookingId { get; set; }

        [Column(TypeName = "date")]
        public DateTime PickupDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReturnDate { get; set; }

        public double RentalCost { get; set; }

        public int CustomerCustomerId { get; set; }

        public int Car_CarId { get; set; }

        public virtual Car Car { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Reviews { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
