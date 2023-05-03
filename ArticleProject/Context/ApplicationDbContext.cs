using ArticleProject.Entities.publisher;
using Microsoft.EntityFrameworkCore;

namespace ArticleProject.Context
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        } 

        public DbSet<publisher>   publishers   { get; set; }
        public DbSet<Articlee> Articlees { get; set; }
    }
}
