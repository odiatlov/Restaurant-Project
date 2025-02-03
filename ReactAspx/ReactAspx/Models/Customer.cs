using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReactAspx.Models
{
    public class Customer
    {
        [Key] // Key in Database table Customer
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        [NotMapped] // Not in Database
        public string ConfirmPassword { get; set; }
    }
}