using System;
using System.Collections.Generic;


namespace Models
{
    public class User
    {
        public User(){}
        public User(int id)
        {
            this.ID = id;
        }
        public int ID {get; set;}
        public string uname {get;set;}
        public string pass {get;set;}
        public bool Admin {get; set;}
    }
}