using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_MVP.Models
{
    internal class CategoriesModel
    {
        [DisplayName("Category Id")]
        public int CatId { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage ="Category Name is required")]
        [StringLength(80, MinimumLength = 3, ErrorMessage ="Category Name must be between 3 and 80 characters")]
        public string CatName { get; set; }

        [DisplayName("Category Description")]
        [Required(ErrorMessage = "Description Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Category Description must be between 3 and 50 characters")]
        public string CatDescription { get; set; }

    }
}
