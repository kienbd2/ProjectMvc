namespace Model.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long? UserID { get; set; }

        public long? CustomerID { get; set; }

        public long? ServicesID { get; set; }

        public long? ProductID { get; set; }

        public int? Quantity { get; set; }

        public double? Price { get; set; }

        public double? Price_Total { get; set; }

        public double? Sale { get; set; }

        public double? Payment { get; set; }

        public bool? Status { get; set; }
    }
}
