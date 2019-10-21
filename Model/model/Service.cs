namespace Model.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public double? Price { get; set; }

        public DateTime? Date { get; set; }

        public long? CustomerID { get; set; }

        public long? UserID { get; set; }
    }
}
