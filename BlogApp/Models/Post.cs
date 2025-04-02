using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.UtcNow;

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
