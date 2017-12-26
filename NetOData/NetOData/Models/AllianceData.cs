using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetOData.Models
{
    [Table("AllianceData")]
    public partial class AllianceData
    {
        public int ID { get; set; }

        public int? PersonID { get; set; }

        public DateTime? HostDate { get; set; }

        public DateTime? FirstIn { get; set; }

        public DateTime? LastOut { get; set; }

        [StringLength(60)]
        public string UpdateUser { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
