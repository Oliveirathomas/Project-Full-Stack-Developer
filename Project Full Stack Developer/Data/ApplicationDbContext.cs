using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_Full_Stack_Developer.Models;

namespace Project_Full_Stack_Developer.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Project_Full_Stack_Developer.Models.Actor> Actor { get; set; }
        public DbSet<Project_Full_Stack_Developer.Models.Category> Category { get; set; }
        public DbSet<Project_Full_Stack_Developer.Models.Director> Director { get; set; }
        public DbSet<Project_Full_Stack_Developer.Models.Movie> Movie { get; set; }
        public DbSet<Project_Full_Stack_Developer.Models.Prodution> Prodution { get; set; }
        public DbSet<Project_Full_Stack_Developer.Models.Theater> Theater { get; set; }
    }
}