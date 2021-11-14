using System.ComponentModel.DataAnnotations;

namespace MyMusicPlaylist.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Title { get; set; }
    }
}
