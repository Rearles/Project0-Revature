﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Zipcode { get; set; }
        public decimal Rating { get; set; }
        public int Cnt { get; set; }
    }
}
