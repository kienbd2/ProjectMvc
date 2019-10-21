namespace Model.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [StringLength(50)]
        public string NameProduct { get; set; }

        [StringLength(50)]
        public string Image { get; set; }

        public decimal? Price { get; set; }

        public int? Quantity { get; set; }

        public bool? Status { get; set; }

        public double? Sale { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
