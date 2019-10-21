namespace Model.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sale")]
    public partial class Sale
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long? CustumerID { get; set; }

        public long? ProductID { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateEnd { get; set; }

        public bool? Status { get; set; }
    }
}
