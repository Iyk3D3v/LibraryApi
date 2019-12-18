namespace NetLibraryAPI.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string Username { get; set; }

        public byte[] Passwordhash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}