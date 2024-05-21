using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication8.Models
{
    public class Workes
    {
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Position { get; set; }
        public string ImgUrl { get; internal set; }
        [NotMapped]
        public IFormFile ImgFile
        {
            get; set;
        }

    }
}
