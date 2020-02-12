using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APINetCore.Models.Entities
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(60)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(60)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string DateOfBirth { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string Age { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string City { get; set; }


    }
}
