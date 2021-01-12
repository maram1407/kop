﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string FIO { get; set; }
        [Required]
        public DateTime DatePostuplenie { get; set; }
        public virtual List<NapravlenieStudent> Napravlenies { get; set; }
    }
}
