using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCoreProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adınızı Girniz.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Girniz.")]
        public string Password { get; set; }
    }
}
