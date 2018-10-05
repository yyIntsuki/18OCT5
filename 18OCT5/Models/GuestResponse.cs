using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _18OCT5.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Ange ditt namn")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Ange ditt mejl")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Ange ditt nummer")]
        public string Phone { get; set; }
    }
}