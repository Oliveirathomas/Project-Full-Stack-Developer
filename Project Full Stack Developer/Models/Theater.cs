using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Project_Full_Stack_Developer.Models
{
    public class Theater
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Number of seats")]
        public int NumberSeats { get; set; }
        [Display(Name = "Number of theater rooms")]
        public int NumberRooms { get; set; }
        [Display(Name = "Date of creation")]
        public DateTime Age { get; set; }
        public string Adress { get; set; }
        [ValidateNever]
        public ICollection<Movie> Movies { get; set; }
        public string imgPath { get; set; }
    }
}
