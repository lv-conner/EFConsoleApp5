using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EFConsoleApp5.Model;

namespace EFConsoleApp5
{
    public class PersonMap:EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            ToTable("Persons").HasKey(p => p.Id).HasIndex(p => p.Id).IsClustered();
            HasIndex(p => p.Name).IsClustered(false).HasName("PersonNameIndex");
            HasMany(p => p.Books).WithRequired().HasForeignKey(p => p.PersonId).WillCascadeOnDelete();
        }
    }

    public class AuthorMap:EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            ToTable("Authors").HasKey(p => p.Id).HasIndex(p => p.Id).IsClustered();
            HasIndex(p => p.Name).IsClustered(false).HasName("AuthorNameIndex");
            Property(p => p.PenName).IsRequired().IsUnicode().HasMaxLength(50).HasColumnName("PenName");
        }
    }

    public class BookMap:EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            ToTable("Authors").HasKey(p => p.Id).HasIndex(p => p.Id).IsClustered();
            HasIndex(p => p.Name).IsClustered(false).HasName("AuthorNameIndex");
            HasMany(p => p.Authors).WithRequired().HasForeignKey(p => p.BookId).WillCascadeOnDelete();
        }
    }
}
