using Microsoft.EntityFrameworkCore;
using PersonalBlog.Interfaces;
using PersonalBlog.Models;

namespace PersonalBlog.Services
{
    public class MicrosoftSQLServerDataService : IDataService
    {
        private readonly BlogContext _context;

        public MicrosoftSQLServerDataService(BlogContext context)
        {
            _context = context;
        }

        public async Task Create(Post model)
        {
            await _context.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public Task<List<Post>> GetAll()
        {
            return _context.Posts.ToListAsync();
        }
    }
}
