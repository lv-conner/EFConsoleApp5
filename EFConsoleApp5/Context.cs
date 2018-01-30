using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EFConsoleApp5.Model;
using EFConsoleApp5.Migrations;

namespace EFConsoleApp5
{
    public class Context:DbContext
    {
        public Context():base("data source=PRCNMG1L0311;initial catalog=BookContext;user id=sa;password=******;")
        {
            Database.SetInitializer<Context>(new MigrateDatabaseToLatestVersion<Context,MyContextConfiguration>());
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Person> Persons { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
