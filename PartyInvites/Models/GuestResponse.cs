using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please enter phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="Please choose whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}