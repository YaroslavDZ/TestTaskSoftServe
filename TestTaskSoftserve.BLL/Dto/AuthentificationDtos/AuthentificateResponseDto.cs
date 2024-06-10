using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskSoftServe.BLL.Dto.AuthentificationDtos
{
    public class AuthentificateResponseDto
    {
        public string? Name { get; set; } = string.Empty;

        public string? Email {  get; set; } = string.Empty;

        public string? Token {  get; set; } = string.Empty;

        public DateTime Expiration { get; set; }

        public string? Refreshtoken {  get; set; } = string.Empty;

        public DateTime RefreshTokenExpirationDateTime { get; set; }
    }
}
