using System;
using System.ComponentModel.DataAnnotations;

namespace MyCompanyApp.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        // Primary key entity
        [Required]
        public Guid Id { get; set; }

        [Display(Name="Name (header)")]
        public virtual string Title { get; set; }
        
        [Display(Name="Short description")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Full description")]
        public virtual string Text { get; set; }

        [Display(Name = "Title image")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO metatag Title")]
        public string MetaTitle { get; set; }

        [Display(Name = "SEO metatag Desription")]
        public string MetaDescription { get; set; }

        [Display(Name = "SEO metatag Keywords")]
        public string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; } 
    }
}
