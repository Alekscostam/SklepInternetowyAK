using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SklepInternetowyAK.Controllers;
using SklepInternetowyAK.Models;

namespace SklepInternetowyAK.ViewModels
{
    public class ManageViewModel
    {
        public UserData UserData{ get; set; }
        public ChangePasswordViewModel ChangePasswordViewModel { get; set; }
        public ManageController.ManageMessageId? Message{ get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Pole jest wymagane")]
        [DataType(DataType.Password)]
        [Display(Name = "Bieżące hasło")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [DataType(DataType.Password)]
        [Display(Name = "Nowe hasło")]
        public string NewPassword { get; set; }


        [Required(ErrorMessage = "Pole jest wymagane")]
        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź nowe hasło")]
        [Compare("NewPassword", ErrorMessage = "Nowe hasło i potwierdzenia hasła nie są zgodne.")]
        public string ConfirmPassword { get; set; }
    }
}