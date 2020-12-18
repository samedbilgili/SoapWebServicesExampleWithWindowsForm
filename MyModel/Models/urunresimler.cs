namespace MyModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("urunresimler")]
    public partial class urunresimler
    {
        public int ID { get; set; }

        public int urunID { get; set; }

        public string resim { get; set; }

        public int? siralama { get; set; }
    }
}
