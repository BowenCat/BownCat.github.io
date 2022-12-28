namespace BizDataLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product //貨品基本明細檔
    {
        [Key]
        [StringLength(10)]
        public string PartNo { get; set; }

        [Required]
        [StringLength(50)]
        public string PartName { get; set; }
    }
}
