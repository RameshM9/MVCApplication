using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Model_View_Controller.Models
{
    public class Product
    {
        [Display(Name = "Product Number")]
        public int ProdctId { get; set; }
        [Display (Name ="Product Name")]
        public string Name { get; set; }
        [Display(Name = "Product Price")]
        public decimal Price { get; set; } 
    }
}