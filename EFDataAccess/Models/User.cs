using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDataAccess.Models
{
    public class User
    {
        public Guid Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public ICollection<Role> Roles { get; set; } = new List<Role>();
    }
}