using NetLibraryAPI.DTOs;

namespace NetLibraryAPI.Managers.Interface
{
    public interface IUserManager
    {
         void Create(UserDto user);

         ResponseDto Login(UserDto user);
    }
}