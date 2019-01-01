namespace TrafficTicketsSystem10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Driver
    {
        public int DriverId { get; set; }

        [StringLength(20)]
        public string DrvLicNumber { get; set; }

        [StringLength(25)]
        public string FirstName { get; set; }

        [StringLength(25)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string County { get; set; }

        [StringLength(5)]
        public string State { get; set; }

        [StringLength(50)]
        public string ZIPCode { get; set; }
    }
}
