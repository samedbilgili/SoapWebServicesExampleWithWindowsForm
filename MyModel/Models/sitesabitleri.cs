namespace MyModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sitesabitleri")]
    public partial class sitesabitleri
    {
        public long ID { get; set; }

        [StringLength(250)]
        public string sitebaslik { get; set; }

        public string resim { get; set; }

        public string googleanahtar { get; set; }

        public string googleaciklama { get; set; }

        public string siteicon { get; set; }

        [StringLength(50)]
        public string siterenkkodu { get; set; }
    }
}
