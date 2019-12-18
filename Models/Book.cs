namespace NetLibraryAPI.Models
{
    public class Book
    {
        [System.ComponentModel.DataAnnotations.Key]
       public int BookId { get; set; } 

       public string Title { get; set; }

       public string Isbn { get; set; }

//on borrowed book, set Availability to N
       public string Available { get; set; }
    }
}