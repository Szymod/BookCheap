using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookCheap.Clients.WebClient.Models
{
    public class UserViewModel
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "Imię")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "Nazwisko")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Pole wymagane", AllowEmptyStrings=false)]
        [Display(Name = "Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Pole wymagane", AllowEmptyStrings=false)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "Powtórz hasło")]
        [Compare("Password", ErrorMessage = "Niepoprawne haasło")]
        public string ComparePassword { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "e-mail")]
        [EmailAddress(ErrorMessage = "Niepoprawny adres e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "Telefon")]
        [RegularExpression(@"\d{9}", ErrorMessage = "Niepoprawny numer telefonu")]
        public string Phone { get; set; }
    }
}