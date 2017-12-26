using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetOData.Models
{
    [Table("Announce")]
    public partial class Announce
    {
        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Detail { get; set; }

        public bool? Active { get; set; }

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
