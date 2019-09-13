namespace MelbourneCar247.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Review
    {
        public int ReviewId { get; set; }

        [Required]
        public string Rating { get; set; }

        [Required]
        public string Feedback { get; set; }

        public int Booking_BookingId { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
