namespace TrafficTicketsSystem10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vehicle
    {
        public int VehicleId { get; set; }

        [StringLength(20)]
        public string TagNumber { get; set; }

        [StringLength(20)]
        public string DrvLicNumber { get; set; }

        [StringLength(40)]
        public string Make { get; set; }

        [StringLength(40)]
        public string Model { get; set; }

        public int? VehicleYear { get; set; }

        [StringLength(32)]
        public string Color { get; set; }
    }
}
