﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
