namespace demo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WarehouseOrder")]
    public partial class WarehouseOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int warehouseId { get; set; }

        public int orderId { get; set; }

        public virtual Order Order { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
