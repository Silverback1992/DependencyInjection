using System.ComponentModel.DataAnnotations;

namespace PersonalBlog.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public DateTime PostDateTime { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
