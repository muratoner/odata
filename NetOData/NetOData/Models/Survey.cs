using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetOData.Models
{
    [Table("Survey")]
    public partial class Survey
    {
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public bool Active { get; set; }

        public DateTime? EntryDateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string EnteredBy { get; set; }

        public DateTime? UpdatedDateTime { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public bool Deleted { get; set; }

        public virtual ICollection<SurveyItem> SurveyItems { get; set; }
    }
}
