namespace MyModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("iletisim")]
    public partial class iletisim
    {
        public long ID { get; set; }

        [StringLength(250)]
        public string baslik { get; set; }

        [StringLength(50)]
        public string telefon { get; set; }

        [StringLength(50)]
        public string faks { get; set; }

        [StringLength(250)]
        public string mailadresi { get; set; }

        public string adres { get; set; }

        [StringLength(500)]
        public string facebook { get; set; }

        [StringLength(500)]
        public string twitter { get; set; }

        [StringLength(500)]
        public string instagram { get; set; }

        [StringLength(50)]
        public string whatsapp { get; set; }
    }
}
