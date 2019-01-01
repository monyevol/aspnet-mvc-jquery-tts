namespace TrafficTicketsSystem10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TrafficViolation
    {
        public int TrafficViolationId { get; set; }

        [StringLength(20)]
        public string CameraNumber { get; set; }

        [StringLength(20)]
        public string TagNumber { get; set; }

        [StringLength(30)]
        public string ViolationName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ViolationDate { get; set; }

        public TimeSpan? ViolationTime { get; set; }

        [StringLength(10)]
        public string PhotoAvailable { get; set; }

        [StringLength(10)]
        public string VideoAvailable { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PaymentDueDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PaymentDate { get; set; }

        public decimal? PaymentAmount { get; set; }
    }
}
