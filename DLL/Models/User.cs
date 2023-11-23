using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace DLL.Models
{
    public partial class User
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Phonenumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
