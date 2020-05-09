using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DynamicVML;

namespace BookAuthors.ViewModels
{
    public class AuthorViewModel
    {
        public int Id { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Authored books")]
        public virtual DynamicList<BookViewModel, MyOptions<BookViewModel>> Books { get; set; } = 
            new DynamicList<BookViewModel, MyOptions<BookViewModel>>();


        //// Note: you can make the above look simpler if you add a new class for your collection:
        //public class BookList : DynamicList<BookViewModel, Options<BookViewModel>>
        //{
        //}

        //// and then use it as
        //[Display(Name = "Authored books")]
        //public virtual BookList Books { get; set; } = new BookList();
    }
}
