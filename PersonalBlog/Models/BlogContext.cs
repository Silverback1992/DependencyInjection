using Microsoft.EntityFrameworkCore;

namespace PersonalBlog.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}
