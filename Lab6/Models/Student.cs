using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public int SymbolNumber { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Address { get; set; }

    }
}
