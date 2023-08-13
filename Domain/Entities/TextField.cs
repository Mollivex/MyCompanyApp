using System.ComponentModel.DataAnnotations;

namespace MyCompanyApp.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Page name(header)")]
        public override string Title { get; set; } = "Information page";

        [Display(Name = "Page content")]
        public override string Text { get; set; } = "Content edit by administrator";
    }
}
