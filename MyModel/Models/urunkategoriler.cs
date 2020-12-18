namespace MyModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("urunkategoriler")]
    public partial class urunkategoriler
    {
        public int ID { get; set; }

        [StringLength(150)]
        public string adi { get; set; }

        public string resim { get; set; }

        [StringLength(200)]
        public string googleanahtar { get; set; }

        [StringLength(200)]
        public string googleaciklama { get; set; }
    }
}
