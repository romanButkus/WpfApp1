using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace DLL.Models
{
    public partial class Teacher
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(13)]
        public string PhoneNumber { get; set; }

        public int? StudentId { get; set; }

        public string ImagePath { get; set; }

        public virtual Student Students { get; set; }
    }
}
