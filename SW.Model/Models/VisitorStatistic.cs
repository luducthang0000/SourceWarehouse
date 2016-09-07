using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public DateTime VisitDate { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(64)]
        public string IPAddress { get; set; }
    }
}
