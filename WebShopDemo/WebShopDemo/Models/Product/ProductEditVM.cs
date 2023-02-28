﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebShopDemo.Models.Brand;
using WebShopDemo.Models.Category;

namespace WebShopDemo.Models.Product
{
    public class ProductEditVM
    {
        public ProductEditVM()
        {
            Brands = new List<BrandPairVM>();
            Categories = new List<CategoryPairVM>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Brand")]
        public int BrandId { get; set; }
        public virtual List<BrandPairVM> Brands { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public virtual List<CategoryPairVM> Categories { get; set; }

        [Display(Name = "Picture")]
        public string Picture { get; set; }

        [Required]
        [Range(0, 5000)]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Discount")]
        public decimal Discount { get; set; }
    }
}
