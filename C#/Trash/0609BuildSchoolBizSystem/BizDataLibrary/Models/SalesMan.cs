namespace BizDataLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesMan")]
    public partial class SalesMan //業務員基本明細檔
    {
        [Key]
        public int JobNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }
    }
}
