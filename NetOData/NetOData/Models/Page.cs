using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetOData.Models
{
    [Table("Page")]
    public partial class Page
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Content { get; set; }

        public bool Active { get; set; }

        public int CategoryID { get; set; }

        public int Order { get; set; }

        public DateTime EntryDateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string EnteredBy { get; set; }

        public DateTime? UpdatedDateTime { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public bool Deleted { get; set; }

        public virtual Category Category { get; set; }
    }
}
