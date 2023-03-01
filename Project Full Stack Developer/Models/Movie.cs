using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Project_Full_Stack_Developer.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [Display(Name = "Release date")]
        public DateTime ReleaseDate { get; set; }
        public int Oscars { get; set; }
        [ValidateNever]
        public ICollection<Actor> Actors { get; set; }
        [ForeignKey("Category")]
        [Display(Name = "Category")]
        public int IdCategory { get; set; }
        [ValidateNever]
        public Category Category { get; set; }
        [ForeignKey("Director")]
        [Display(Name = "Director")]
        public int IdDirector { get; set; }
        [ValidateNever]
        public Director Director { get; set; }
        [ForeignKey("Prodution")]
        [Display(Name = "Production")]
        public int IdProdution { get; set; }
        [ValidateNever]
        public Prodution Prodution { get; set; }
        [ValidateNever]
        public ICollection<Theater> Theaters { get; set; }
        public string imgPath { get; set; }
    }
}
