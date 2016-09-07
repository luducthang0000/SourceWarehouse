using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SW.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        [Required]
        public string Content { get; set; }
    }
}