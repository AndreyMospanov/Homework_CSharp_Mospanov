using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_T3
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public Book(string title, string author, string description)
        {
            Title = title;
            Author = author;
            Description = description;
        }

        public Book() : this("untitled", "noname", "no description") { }

        public override int GetHashCode()
        {
            return 434131217 + EqualityComparer<string>.Default.GetHashCode(Title);
        }

        public override bool Equals(object obj)
        {
            return obj is Book book &&
                   Title == book.Title;
        }
    }
}
