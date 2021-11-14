using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMusicPlaylist.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Title { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Performer{ get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Url { get; set; }
        public int Review { get; set; }

        [Column(TypeName = "bit")]
        public bool Favourite { get; set; }
        public DateOnly DateOfInput { get; set; }
        public DateOnly DateOfLastEdit { get; set; }
        public Category SongCategory { get; set; }
    }
}
