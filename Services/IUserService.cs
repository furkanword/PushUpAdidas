using API.Dtos;

namespace API.Services;

public interface IUserService
{
    Task <string> RegistrerAsync (RegisterDto model);
    Task <DatosUsuarioDto> GetTokenAsync (LoginDto model);
    Task<DatosUsuarioDto> GetTokenAsync(AuthenticationToken model);
    Task <string> AddRoleAsync (AddRoleDto model);
}