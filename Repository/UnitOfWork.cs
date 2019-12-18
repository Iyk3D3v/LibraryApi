using NetLibraryAPI.Models;

namespace NetLibraryAPI.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<User> User {private set; get;}

        public IRepository<Book> Book {private set; get;}

        public IRepository<BorrowedBook> BorrowedBook {private set; get;}

        public IRepository<Admin> Admin{private set; get;}

        
        private DataContext _context;
        public UnitOfWork(DataContext context)
        {
            _context = context;

            User = new Repository<User>(context);

            Book = new Repository<Book>(context);

            BorrowedBook = new Repository<BorrowedBook>(context);

            Admin  = new Repository<Admin>(context);
        }
    }
}