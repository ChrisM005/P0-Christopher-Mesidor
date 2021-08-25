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
        public User(string username, string password)
        {
            this.uname = username;
            this.pass = password;
        }
        public int ID {get; set;}
        public string uname {get;set;}
        public string pass {get;set;}
        public bool Admin {get; set;}
    }
}