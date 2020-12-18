namespace MyModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("admin")]
    public partial class admin
    {
        public long ID { get; set; }

        [StringLength(250)]
        public string kullaniciadi { get; set; }

        [StringLength(250)]
        public string sifre { get; set; }

        [StringLength(250)]
        public string mailadresi { get; set; }
    }
}
