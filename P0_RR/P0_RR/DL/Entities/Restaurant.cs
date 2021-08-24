﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Rating { get; set; }
        public string Location { get; set; }
        public int ZipCode { get; set; }
    }
}
