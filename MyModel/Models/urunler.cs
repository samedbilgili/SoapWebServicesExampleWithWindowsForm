namespace MyModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("urunler")]
    public partial class urunler
    {
        public int ID { get; set; }

        public int kategoriID { get; set; }

        [StringLength(150)]
        public string adi { get; set; }

        public string kisaaciklama { get; set; }

        public string aciklama { get; set; }

        public string resim { get; set; }

        public string anasayfaaciklama { get; set; }

        public bool? anasayfadagoster { get; set; }

        [StringLength(200)]
        public string googleanahtar { get; set; }

        [StringLength(200)]
        public string googleaciklama { get; set; }
    }
}
