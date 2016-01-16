using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookCheap.Clients.WebClient.Models
{
    public class ApplicationViewModel
    {
       
        [Key]
        

        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "Opis")]
        public string Description { get; set; }

/*        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "Typ hotelu")]
        public HotelType HotelType { get; set; }
        */

        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "Miasto")]
        public string City { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "Ulica")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "Kod pocztowy")]
        [RegularExpression(@"\d{2}-\d{3}", ErrorMessage = "Niepoprawny format kodu pocztowego")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "Numer domu")]
        [RegularExpression(@"\d", ErrorMessage = "Musi być podana cyfra")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "NIP")]
        [RegularExpression(@"\d{10}", ErrorMessage = "Musi być podana cyfra")]
        public int Nip { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "Data")]
        public DateTime ApplicationDate { get; set; }
    }
}