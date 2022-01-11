﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseCW.Shared
{
    public class Todo
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
