namespace MyModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("slider")]
    public partial class slider
    {
        public long ID { get; set; }

        [StringLength(200)]
        public string yazi1 { get; set; }

        [StringLength(500)]
        public string yazi2 { get; set; }

        public string resim { get; set; }

        [StringLength(50)]
        public string aktif { get; set; }

        [StringLength(50)]
        public string linkvaryok { get; set; }

        public string link { get; set; }

        public int? siralama { get; set; }
    }
}
