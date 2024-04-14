using MagicVilla_Api.Model;
using MagicVilla_Api.Model.DTO;

namespace MagicVilla_Api.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<Localuser> Register(RegistrationRequestDTO registrationRequestDTO);
    }
}
