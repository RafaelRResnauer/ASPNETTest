﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETTest.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "The description is necessary")]
        public string Description { get; set; }
    }
}
