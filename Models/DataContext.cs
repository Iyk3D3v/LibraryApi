using Microsoft.EntityFrameworkCore;

namespace NetLibraryAPI.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<BorrowedBook> BorrowedBooks { get; set; }

        public DbSet<Admin> Admins { get; set; }


    }
}