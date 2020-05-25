using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bookKeeper_Entity
{
    public class User
    {
        [Key][Required]
        public int UserId { get; set; }

        [Required]
        [Index(IsUnique = true)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}