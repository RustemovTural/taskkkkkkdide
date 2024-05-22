using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agency.Models
{
    public class Portfolio
    { 
        public int Id { get; set; }
        [StringLength(25)]
        public string FullName { get; set; }
        [MinLength(5)]
        [MaxLength(50)]
        public string Position { get; set; }
        public string? ImgUrl { get; set; }
        [NotMapped]
        public IFormFile PhotoFile { get; set; }



    }
}
