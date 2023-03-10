using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Project_Full_Stack_Developer.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Rating { get; set; }
        public int Oscars { get; set; }
        [ValidateNever]
        public ICollection<Movie> Movies { get; set; }
        public string imgPath { get; set; }
    }
}
