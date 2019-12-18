using System.Linq;
using System;
using System.Collections.Generic;
using NetLibraryAPI.DTOs;
using NetLibraryAPI.Managers.Interface;
using NetLibraryAPI.Models;
using NetLibraryAPI.Repository;

namespace NetLibraryAPI.Managers.Implementation
{
    public class BookManager : IBookManager
    {
        private IUnitOfWork _unit;
        public BookManager(UnitOfWork unit)
        {
            _unit = unit;
        }
        public ResponseDto Create(BookDto book)
        {
            var response = new ResponseDto();
           
            try{
                if(book != null)
                {
                    var newBook = new Book{
                        Title=  book.Title,
                        Isbn = book.Isbn,
                        Available = "Y"
                    };
                    _unit.Book.Insert(newBook);
                    response.Code = 0; //for success
                    response.ErrorMessage = "";
                    response.Status = "Success";

                    return response;
                }
                else
                {
                    response.Code = -1; //for failure
                    response.ErrorMessage = "Entity was null";
                    response.Status = "Failed";

                    return response;
                }
            }
            catch(Exception e)
            {
                response.Code = -2; //for failure due to catch
                    response.ErrorMessage ="Error: "+ e.Message == null ? e.InnerException.Message : e.Message;
                    response.Status = "Failed";

                    return response;
            }
            
        }

        public ResponseDto Delete(BookDto book)
        {
            var response = new ResponseDto();
            //could use book !=  null as outer cjheck || check for it in controller
            try{
                if(book != null)
                {
                    var bookToDelete = _unit.Book.GetByConditionNoTracking(b => b.BookId == book.Id).FirstOrDefault();
                   if(bookToDelete != null)
                   {
                       _unit.Book.Delete(bookToDelete);
                    response.Code = 0; //for success
                    response.ErrorMessage = "";
                    response.Status = "Success";

                    return response;
                   }
                    
                }
                else{
                     response.Code = -1; //for success
                    response.ErrorMessage = "Entity is Null";
                    response.Status = "Success";

                    return response;
                }
            }
            catch(Exception ex)
            {
                  response.Code = -2; //for success
                    response.ErrorMessage = "Error: "+ ex.Message == null? ex.InnerException.Message : ex.Message;
                    response.Status = "Failed";

                    return response;
            }
        return response;

        }

        public List<BookDto> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<BookDto> GetByTitle(string title)
        {
            throw new System.NotImplementedException();
        }

        public ResponseDto Update(BookDto book)
        {
            //would chk for null in the controller
            var response  = new ResponseDto();
            try{
                    var bookForUpdate = _unit.Book.GetByConditionNoTracking(book=> book.BookId == book.BookId).FirstOrDefault();
                    _unit.Book.Update(bookForUpdate);
                    response.Code = 0;
                    response.ErrorMessage = "Updated Successfully";
                    response.Status = "Success";
                    return response;

            }
            catch(Exception ex)
            {
                 response.Code = 0;
                 //error should be logged tho
                    response.ErrorMessage = "Error: "+ex.Message ==  null? ex.InnerException.Message : ex.Message;
                    response.Status = "Success";
                    return response;
            }
           // return response;

        }
    }
}