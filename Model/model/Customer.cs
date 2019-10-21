namespace Model.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long? UserId { get; set; }
        public long? TeleId { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Email { get; set; }

        public long? Bill_ID { get; set; }

        public bool Status { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }
    }
}
