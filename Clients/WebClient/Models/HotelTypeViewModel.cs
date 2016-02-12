using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookCheap.Clients.WebClient.Models
{
    public class HotelTypeViewModel
    {
        [Key]

        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
    }
}