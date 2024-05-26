using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShoping.Model
{
    public class Product
    {
        public int Id { get; set; }
            
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public double ListPrice { get; set; }
        [Required]
        [Range(1, 5000)]
        public double Price { get; set; }
        [Required]
        [Range(1, 4500)]
        public double Price50 { get; set; }
        [Required]
        [Range(1, 3000)]
        public double Price100 { get; set; }
        [Required]
        [Display(Name ="Image Url")]
        public string ImageUrl {  get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Display(Name = "CoverType")]
        public int CovrTypeId {  get; set; }
        public CoverType CoverType { get; set; }



    }
}
