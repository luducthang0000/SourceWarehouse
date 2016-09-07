using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(64)]
        public string ID { get; set; }
        [MaxLength(64)]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(64)]
        public string Type { get; set; }
    }
}
