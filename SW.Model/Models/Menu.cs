using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SW.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [Required]
        [MaxLength(512)]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        [Required]
        public int MenuGroupID { get; set; }

        [ForeignKey("MenuGroupID")] 
        public virtual MenuGroup MenuGroup { set; get; }
        [Column(TypeName = "varchar")]
        [MaxLength(10)]
        public string Target { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}