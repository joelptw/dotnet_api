using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookApiProject.Models
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Country name cannot be more than 50 characteres.")]
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Country Country { get; set; }
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }            
    }
}
