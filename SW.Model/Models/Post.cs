using SW.Model.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SW.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public string Alias { get; set; }

        [Required]
        public int PostCategoryID { get; set; }

        public virtual PostCategory PostCategory { get; set; }

        [MaxLength(512)]
        public string Image { get; set; }

        [MaxLength(512)]
        public string Description { get; set; }

        public string Content { get; set; }
        public int? HomeFlag { get; set; }
        public int? HotFlag { get; set; }
        public int? ViewCount { get; set; }
    }
}