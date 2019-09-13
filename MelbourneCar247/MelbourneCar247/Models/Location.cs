namespace MelbourneCar247.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Location
    {
        public int LocationId { get; set; }

        public int Postcode { get; set; }

        [Required]
        public string Suburb { get; set; }
    }
}
