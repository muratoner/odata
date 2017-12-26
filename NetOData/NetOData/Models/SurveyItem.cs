using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetOData.Models
{
    [Table("SurveyItem")]
    public partial class SurveyItem
    {
        public int ID { get; set; }

        public int SurveyID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public DateTime EntryDateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string EnteredBy { get; set; }

        public DateTime? UpdatedDateTime { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public bool Deleted { get; set; }

        public virtual Survey Survey { get; set; }
    }
}
