namespace TrafficTicketsSystem10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Camera
    {
        public int CameraId { get; set; }

        [StringLength(20)]
        public string CameraNumber { get; set; }

        [StringLength(40)]
        public string Make { get; set; }

        [StringLength(40)]
        public string Model { get; set; }

        [StringLength(120)]
        public string Location { get; set; }
    }
}
