using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp5.Model
{
    public class Person : BaseClass
    {
        public Person()
        {
            Books = new List<Book>();
        }
        public virtual ICollection<Book> Books { get; set; }
    }

    public class Book : BaseClass
    {
        public Book()
        {
            Authors = new List<Author>();
        }
        public string PersonId { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
    }

    public class Author : BaseClass
    {
        public string BookId { get; set; }
        public string PenName { get; set; }
    }
    public abstract class BaseClass
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }





}
