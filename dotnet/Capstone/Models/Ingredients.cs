﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Ingredients
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Measurement { get; set; }

        public int UserId { get; set; }
    }
}
