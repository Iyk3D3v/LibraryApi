using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace NetLibraryAPI.Models
{
    public class BorrowedBook
    
    {
        [Key]
        public int BorrowedBookId { get; set; }

        public string Username { get; set; }

        public DateTime BorrowedDate { get; set; }

        public DateTime ReturnDate { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
    }
}