using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftServe.BLL.Dto.AuthentificationDtos;
using TestTaskSoftServe.DAL.Entities.User;

namespace TestTaskSoftServe.BLL.Services.Interfaces.Authentification
{
    public interface IJwtService
    {
        AuthentificateResponseDto CreateJwtToken(ApplicationUser user);
        ClaimsPrincipal? GetPrincipalFromJwtToken(string? token);
    }
}
