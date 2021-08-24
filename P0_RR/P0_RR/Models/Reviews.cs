using System;
using System.Collections.Generic;


namespace Models
{
    public class Reviews
    {
        public Reviews(){}
        public Reviews(int id)
        {
            this.ID = id;
        }
        public Reviews(int ra, string co)
        {
            this.rating = ra;
            this.comments = co;
        }
        public int ID {get; set;}
        public int rating {get;set;}
        public string comments {get;set;}
    }
}