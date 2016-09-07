using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SW.Model.Abstracts
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        [Column(TypeName = "varchar")]
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        [Column(TypeName = "varchar")]
        string UpdatedBy { get; set; }

        [MaxLength(256)]
        string MetaKeyword { get; set; }

        [MaxLength(256)]
        string MetaDescription { get; set; }

        bool Status { get; set; }
    }
}