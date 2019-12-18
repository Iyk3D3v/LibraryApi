namespace NetLibraryAPI.DTOs
{
    public class UserResponseDto
    {
        public int Code { get; set; }

        public string Status { get; set; }

        public UserDto User { get; set; }
    }
}