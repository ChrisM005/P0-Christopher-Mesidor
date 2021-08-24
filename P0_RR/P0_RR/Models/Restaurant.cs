using System;
using System.Collections.Generic;

namespace Models
{
    public class Restaurant
    {
        public Restaurant(){}
        public Restaurant(int id)
        {
            this.ID = id;
        }

        public int ID {get; set;}
        public string Name {get; set;}
        public decimal Rating {get; set;}
        public string Location {get; set;}
        public int ZipCode {get; set;}
    }
}