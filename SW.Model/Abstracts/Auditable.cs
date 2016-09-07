﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SW.Model.Abstracts
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { get; set; }
        [MaxLength(64)]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(64)]
        public string UpdatedBy { get; set; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }
        [MaxLength(256)]
        public string MetaKeyword { get; set; }
        public bool Status { get; set; }
    }
}