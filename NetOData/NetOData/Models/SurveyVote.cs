using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetOData.Models
{
    [Table("SurveyVote")]
    public partial class SurveyVote
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string User { get; set; }

        public int SurveyItemID { get; set; }

        public byte Deleted { get; set; }

        public virtual SurveyItem SurveyItem { get; set; }
    }
}
