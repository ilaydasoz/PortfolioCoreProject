using System;
using System.ComponentModel.DataAnnotations;


namespace PortfolioCoreProject.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Please enter your name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your surname!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please enter image url!")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Please enter your username!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your password!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter confirm your password!")]
        [Compare("Password", ErrorMessage = "Passwords do not match!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter your e-mail!")]
        public string Mail { get; set; }
    }
}
