using EFConsoleApp5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                var person = db.Persons.First();
                Console.WriteLine(person.Books.First().Authors.First().PenName);
            }
            Console.ReadKey();
        }
        static Person AddPerson()
        {
            var book = new Book()
            {
                Id = "Book1",
                Name = "Good Book",
            };
            var author = new Author()
            {
                Id = "A001",
                Name = "God",
                PenName = "God01"
            };
            book.Authors.Add(author);
            var person = new Person()
            {
                Id = "0001",
                Name = "tim",
            };
            person.Books.Add(book);
            return person;
        }
    }
}
