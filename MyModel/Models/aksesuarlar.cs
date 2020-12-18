namespace MyModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("aksesuarlar")]
    public partial class aksesuarlar
    {
        public int ID { get; set; }

        [StringLength(150)]
        public string adi { get; set; }

        public string resim { get; set; }

        public int? siralama { get; set; }
    }
}
