using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_MVP.Models
{
    internal class ProductsModel
    {
        public int ProductId { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 80 characters")]
        public string ProductName { get; set; }

        [DisplayName("Product price")]
        [Required(ErrorMessage = "Product price is required")]
        public int ProductPrice { get; set; }

        [DisplayName("Product stock")]
        [Required(ErrorMessage = "Product stock is required")]
        public int ProductStock { get; set; }

        [DisplayName("Product Category Id")]
        [Required(ErrorMessage = "Product category Id is required")]
        public int ProductCatId { get; set; }
    }
}
