using System.Collections.Generic;
using NetLibraryAPI.DTOs;

namespace NetLibraryAPI.Managers.Interface
{
    public interface IBookManager
    {
         ResponseDto Create(BookDto book);

         ResponseDto Delete(BookDto book);

         List<BookDto> GetAll();

         ResponseDto Update(BookDto book);

         List<BookDto> GetByTitle(string title);
    }
}