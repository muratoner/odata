using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetOData.Models
{
    [Table("Video")]
    public partial class Video
    {
        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string YoutubeUrl { get; set; }

        [Required]
        [StringLength(500)]
        public string Tags { get; set; }

        [Required]
        [StringLength(150)]
        public string Image { get; set; }

        public int Order { get; set; }

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
