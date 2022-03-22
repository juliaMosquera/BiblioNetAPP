using BiblioNetAPP.Validations;
using System.ComponentModel.DataAnnotations;

namespace BiblioNetAPP.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [FirstCapitalLetter]

        public string BookName { get; set; }
        public int IdAuthor { get; set; }
        public int Price { get; set; }
    
    }
}
