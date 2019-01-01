namespace TrafficTicketsSystem10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ViolationType
    {
        public int ViolationTypeId { get; set; }

        [StringLength(30)]
        public string ViolationName { get; set; }

        public string Description { get; set; }
    }
}
