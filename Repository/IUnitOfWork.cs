using NetLibraryAPI.Models;

namespace NetLibraryAPI.Repository
{
    public interface IUnitOfWork
    {
        
         IRepository<User> User{get;}

         IRepository<Book> Book {get;}

         IRepository<BorrowedBook> BorrowedBook {get;}

         IRepository<Admin> Admin {get;}
         
    }
}