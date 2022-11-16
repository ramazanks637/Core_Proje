using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı girin.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Lütfen soyadınızı girin.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen resim yolunu girin.")]
        public string ImageUrl { get; set; }


        [Required(ErrorMessage ="Lütfen kullanıcı adını girin.")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Lütfen şifre girin.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi tekrar girin.")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Mail girin.")]
        public string Mail { get; set; }

    }
}
