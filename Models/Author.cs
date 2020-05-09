using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DynamicVML;

namespace BookAuthors.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Authored books")]
        public virtual List<Book> Books { get; set; } = new List<Book>();
    }
}
