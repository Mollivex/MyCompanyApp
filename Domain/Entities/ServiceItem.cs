using System.ComponentModel.DataAnnotations;

namespace MyCompanyApp.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage="Fill service name")]
        [Display(Name = "Service name")]
        public override string Title { get; set; }

        [Display(Name = "Service short description")]
        public override string Subtitle { get; set; }

        [Display(Name = "Service full description")]
        public override string Text { get; set; }
    }
}
