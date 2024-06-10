using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TestTaskSoftServe.BLL.Dto.AuthentificationDtos;
using TestTaskSoftServe.BLL.Services.Interfaces.Authentification;
using TestTaskSoftServe.DAL.Entities.User;

namespace Test_Task_SoftServe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IJwtService _jwtService;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, IJwtService jwtService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _jwtService = jwtService;
        }

        [HttpPost]
        public async Task<ActionResult<ApplicationUser>> Register(RegisterDto registerDto)
        {
            ApplicationUser user = new ApplicationUser()
            {
                PersonName = registerDto.PersonName,
                UserName = registerDto.Email,
                Email = registerDto.Email
            };

            IdentityResult result = await _userManager.CreateAsync(user, registerDto.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);

                var authentificationResponse = _jwtService.CreateJwtToken(user);

                user.RefreshToken = authentificationResponse.Refreshtoken;
                user.RefreshTokenExpirationDateTime = authentificationResponse.RefreshTokenExpirationDateTime;
                await _userManager.UpdateAsync(user);

                return Ok(authentificationResponse);
            }
            else
            {
                string errorMessage = string.Join(" | ", result.Errors.Select(e => e.Description));

                return Problem(errorMessage);
            }
        }

        [HttpGet]
        public async Task<IActionResult> IsEmailAlreadyRegistered(string email)
        {
            ApplicationUser? user = await _userManager.FindByEmailAsync(email);

            return user is null ? Ok(true) : Ok(false);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var result = await _signInManager.PasswordSignInAsync(loginDto.Email,
                loginDto.Password, isPersistent: false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                ApplicationUser? user = await _userManager.FindByEmailAsync(loginDto.Email);

                if (user is null)
                {
                    return NoContent();
                }

                var authentificationResponse = _jwtService.CreateJwtToken(user);

                user.RefreshToken = authentificationResponse.Refreshtoken;

                user.RefreshTokenExpirationDateTime = authentificationResponse.RefreshTokenExpirationDateTime;
                await _userManager.UpdateAsync(user);

                return Ok(authentificationResponse);
            }
            else
            {
                return Problem("Invalid id or password");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> GenerateNewAccessToken(TokenModel tokenModel)
        {
            if (tokenModel is null)
            {
                return BadRequest("Invalid client's request");
            }

            string? jwtToken = tokenModel.Token;
            string? refreshToken = tokenModel.RefreshToken;

            ClaimsPrincipal? principal = _jwtService.GetPrincipalFromJwtToken(jwtToken);

            if (principal is null)
            {
                return BadRequest("Invalid jwt access token");
            }

            string? email = principal.FindFirstValue(ClaimTypes.NameIdentifier);

            ApplicationUser? user = await _userManager.FindByEmailAsync(email);

            if (user is null || user.RefreshToken != refreshToken ||
                user.RefreshTokenExpirationDateTime <= DateTime.Now)
            {
                return BadRequest("Invalid refresh token");
            }

            AuthentificateResponseDto authentificateResponseDto = _jwtService.CreateJwtToken(user);

            user.RefreshToken = authentificateResponseDto.Refreshtoken;
            user.RefreshTokenExpirationDateTime = authentificateResponseDto.RefreshTokenExpirationDateTime;
            await _userManager.UpdateAsync(user);

            return Ok(authentificateResponseDto);
        }
    }
}
