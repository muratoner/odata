using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetOData.Models
{
    [Table("Birthday")]
    public partial class Birthday
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Column("Birthday")]
        public DateTime Birthday1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Department { get; set; }

        public DateTime EntryDateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string EnteredBy { get; set; }

        public DateTime? UpdatedDateTime { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public bool Deleted { get; set; }
    }
}
