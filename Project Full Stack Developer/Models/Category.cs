using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Project_Full_Stack_Developer.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Type { get; set; }
        public string Description { get; set; }
        [ValidateNever]
        public ICollection<Movie> Movies { get; set; }
    }
}
