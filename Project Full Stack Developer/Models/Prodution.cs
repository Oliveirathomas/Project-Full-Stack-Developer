using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Project_Full_Stack_Developer.Models
{
    public class Prodution
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        [Display(Name = "Year of foundation")]
        public int DateOfCreation { get; set; }
        [ValidateNever]
        public ICollection<Movie> Movies { get; set; }
        public string imgPath { get; set; }
    }
}
