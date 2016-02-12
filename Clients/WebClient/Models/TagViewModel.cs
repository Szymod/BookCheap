using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookCheap.Clients.WebClient.Models
{
    public class TagViewModel
    {

        [Key]


        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

    }
}