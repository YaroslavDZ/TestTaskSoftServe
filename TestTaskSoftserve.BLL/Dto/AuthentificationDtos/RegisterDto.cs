using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskSoftServe.BLL.Dto.AuthentificationDtos
{
    public class RegisterDto
    {
        public string PersonName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password {  get; set; } = string.Empty;

        public string ConfirmPassword {  get; set; } = string.Empty;

    }
}
