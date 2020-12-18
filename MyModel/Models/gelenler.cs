namespace MyModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gelenler")]
    public partial class gelenler
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string tarihsaat { get; set; }

        [StringLength(50)]
        public string IPadresi { get; set; }

        [StringLength(50)]
        public string isim { get; set; }

        [StringLength(50)]
        public string telefon { get; set; }

        [StringLength(250)]
        public string mailadresi { get; set; }

        public string mesaj { get; set; }

        [StringLength(50)]
        public string okundu { get; set; }
    }
}
