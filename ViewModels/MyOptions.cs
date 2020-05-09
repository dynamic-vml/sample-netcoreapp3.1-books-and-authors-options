using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DynamicVML;

namespace BookAuthors.ViewModels
{
    // When adding custom options it's important to add an interface for the options as 
    // well so we can customize how they affect the iteam rendering. Please see the file 
    // "CustomItemTemplateWithMyOptions.cshtml" for an example on how this can be done

    public interface IMyOptions : IDynamicListItem
    {
        string Title { get; set; }
        string Subtitle { get; set; }
        bool CanRemove { get; set; }
    }

    public class MyOptions<T> : DynamicListItem<T>, IMyOptions
        where T : class
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }

        public bool CanRemove { get; set; }
    }
}
