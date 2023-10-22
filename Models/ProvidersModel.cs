using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_MVP.Models
{
    internal class ProvidersModel
    {
        public int ProviderId { get; set; }

        [DisplayName("Provider Document Number")]
        [Required(ErrorMessage = "Provider documment number is required")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 15 characters")]
        public string ProviderDocNum  { get; set; }

        [DisplayName("Provider Name")]
        [Required(ErrorMessage = "Privider name is required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Provider name must be between 3 and 30 characters")]
        public string ProviderName { get; set; }

        [DisplayName("Provider Address")]
        [Required(ErrorMessage = "Privider address is required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Provider address must be between 3 and 30 characters")]
        public string ProviderAddress { get; set; }

        [DisplayName("Provider Phone Number")]
        [Required(ErrorMessage = "Privider Phone Number is required")]
        [StringLength(15, MinimumLength = 7, ErrorMessage = "Provider Phone Number must be between 7 and 15 characters")]
        public string ProviderPhoneNum { get; set; }

        [DisplayName("Provider eMail")]
        [Required(ErrorMessage = "Privider eMail is required")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Provider eMail must be between 7 and 15 characters")]
        public string ProvidereMail { get; set; }
    }
}
