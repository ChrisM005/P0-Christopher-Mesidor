using System;
using System.Collections.Generic;
using Models;

namespace UI
{
    public class MainMenu : IMenu
    {
        
        //
        public void Start()
        {
            List<Restaurant> res = new List<Restaurant>();
            List<User> person = new List<User>();
            //string rname;
            bool repeat = true;
            bool succeess;
            //Starting menu
            do
            {
                Console.WriteLine("Welcome to Resteraunt Reviewer!");
                Console.WriteLine("0) Exit Login");
                Console.WriteLine("1) New User");
                Console.WriteLine("2) Current User");

                switch(Console.ReadLine())
                {
                    case "0":
                        Console.WriteLine("Exiting ...");
                        repeat = false;
                    break;
                    case "1":
                        CreateUser();
                    break;
                    case "2":
                        succeess = ULogin(person);
                        if(succeess == true)
                        {
                            ChooseRestaurant(person);
                        }
                    break;
                    default:
                        Console.WriteLine("Invalid input, try again.");
                    break;
                }
            } while(repeat);
        }
        
        /// 
        ///Select search for restaurant or to display them
        ///  
        public void ChooseRestaurant(User x)
        {
            bool repeat=true;
            bool adminprivlige = false;
            if(x.Admin == True)
            {
                adminprivlige = true;
            }
            if(adminprivlige==true)
            {
                 do
                 {
                    Console.WriteLine("Welcome to Resteraunt Reviewer!");
                    Console.WriteLine("0) Exit Resterant Reviewer");
                    Console.WriteLine("1) Display List of Restaurants");
                    Console.WriteLine("2) Search for a Restaurant");
                    Console.WriteLine("3) Search for a User");
                    //Console.WriteLine("5) Search for a Resteraunt");

                    switch(Console.ReadLine())
                    {
                       case "0":
                            Console.WriteLine("Exiting ...");
                            repeat = false;
                        break;
                        case "1":
                            ViewAllResteraunt(res);                        
                        break;
                        case "2":
                            SearchResteraunt();
                        break;
                        case "3":
                            SearchUser();
                        break;
                        default:
                            Console.WriteLine("Invalid input, try again.");
                        break;
                    }
                 } while(repeat);
            }
            else
            {
                do
                {
                    Console.WriteLine("Welcome to Resteraunt Reviewer!");
                    Console.WriteLine("0) Exit Resterant Reviewer");
                    Console.WriteLine("1) Display List of Restaurants");
                    Console.WriteLine("2) Search for a Restaurant");
                   // Console.WriteLine("4) Search for a Resteraunt");
                    //Console.WriteLine("5) Search for a Resteraunt");

                    switch(Console.ReadLine())
                    {
                       case "0":
                            Console.WriteLine("Exiting ...");
                            repeat = false;
                        break;
                        case "1":
                            ViewAllResteraunt(res);                        
                        break;
                        case "2":
                            SearchResteraunt();
                        break;
                        default:
                            Console.WriteLine("Invalid input, try again.");
                        break;
                    }
             } while(repeat);
            }
        } 
        
        ///<summery>
        /// Create User
        /// </summery>
        public void CreateUser()
        {
            string username;
            string password;
            User userdata;
            do
            {
                Console.WriteLine("Enter Username: ");
                username = Console.ReadLine();
            }while(String.IsNullOrWhiteSpace(username));
            do    
            {    Console.WriteLine("Enter Password: ");
                password = Console.ReadLine();
            }while(String.IsNullOrWhiteSpace(password));
            userdata = new User();
            userdata.uname = username;
            userdata.pass = password;
            Console.WriteLine($"{userdata.uname} was successfully added!");
        }

        ///<summery>
        /// Create Review
        /// </summery>
        public void MakeReview()
        {
            int input=0;
            string comment = "";
            Reviews ReviewToAdd;

            Console.WriteLine("Enter Review to add out of 5: ");
            
            do
            {
                Console.WriteLine("Rate: ");
                input = Console.Read();

            } while((input >0 && input <=5));

            Console.WriteLine("Comment: ");
            comment = Console.ReadLine();

            ReviewToAdd = new Reviews(input,comment);
            ReviewToAdd = _revbl.MakeReview(ReviewToAdd);

            Console.WriteLine("Review was successfully added!");
        }

        ///<summery>
        /// Create Restaurant
        /// </summery>
        public void AddRestaurant()
        {
            string name;
            Restaurant ResToAdd;            
            do
            {
                Console.WriteLine("Restaurant name: ");
                name = Console.ReadLine();

            } while(int.IsNullOrWhiteSpace(name));

            Console.WriteLine("Comment: ");
            comment = Console.ReadLine();

            ResToAdd = new Restaurant(input,comment);
            ResToAdd = _revbl.AddRestaurant(ResToAdd);

            Console.WriteLine("Retsaurant was successfully added!");
        }

        ///<summery>
        /// User Login
        /// </summery>
        public bool ULogin(List<User> us)
        {
            //User us = new User();
            string un;
            string pw;
            bool uvalid = false;
            bool pvalid = false;
            bool valid =false;

            do
            {
                Console.WriteLine("Username: ");
                un = Console.ReadLine();
                foreach(UriParser x in us)
                {
                    if(un == us[x].uname);
                    {
                        uvalid = true;
                    }
                }
            }while(String.IsNullOrWhiteSpace(un));
                
           do
            {
                Console.WriteLine("Password: ");
                pw = Console.ReadLine();
                foreach(UriParser x in us)
                {
                    if(pw == us[x].pass);
                    {
                        pvalid = true;
                    }
                }
            }while(String.IsNullOrWhiteSpace(pw));

            if(uvalid == true && pvalid == true)
            {
                valid = true;
            }
            return valid;
        }

        ///<sumery>
        /// Display Restaurant
        /// </summery>
        public void ViewAllResteraunt(List<Restaurant> r)
        {
            r = new List<Restaurant>();
            Console.WriteLine("--------------------------------");
            for(int i=0; i< r.Count; i++)
            {
                Console.WriteLine(r[i].Name);
                Console.WriteLine($"{r[i].Rating} out of 5");
                Console.WriteLine(r[i].Location);
                Console.WriteLine(r[i].ZipCode);
                Console.WriteLine("--------------------------------");
            }
        }

        //Display Users
        public void ViewAllUsers(List<User> r)
        {
            r = new List<User>();
            Console.WriteLine("--------------------------------");
            for(int i=0; i< r.Count; i++)
            {
                Console.WriteLine($"User ID: {r[i].ID}");
                Console.WriteLine($"Username: {r[i].uname}");
                Console.WriteLine($"Password: {r[i].pass}");
                Console.WriteLine("--------------------------------");
            }
        }

        //Display Reviews
        public void ViewAllReviews(List<Reviews> r)
        {
            r = new List<Reviews>();
            Console.WriteLine("--------------------------------");
            for(int i=0; i< r.Count; i++)
            {
                //Console.WriteLine($"User ID: {r[i].ID}");
                Console.WriteLine($"Username: {r[i].rating}");
                Console.WriteLine($"Password: {r[i].comments}");
                Console.WriteLine("--------------------------------");
            }
        }

        //Search for the Restaurant
        public void SearchResteraunt()
        {
            List<Restaurant> r = new List<Restaurant>();
            List<User> u = new List<User>();
            string yn;
            string usr;
            string pw;
            int count = 0;
            string input;
            Console.WriteLine("Search the Resterant name: ");
            input = Console.ReadLine();
            for(int i=0; i< r.Count; i++)
            {
                if(input == r[i].Name)
                {
                    Console.WriteLine("Found Restaurant!");
                    Console.WriteLine("Do you want to Review this Restaurant? (y/n)");
                    yn = Console.ReadLine();
                    if(yn != "y" || yn != "n")
                    {
                        do
                        {
                            Console.WriteLine("Invalid Input. Do you want to Review this Restaurant? (y/n)");
                            yn = Console.ReadLine();
                        }while(yn != "y" || yn != "n");
                    }
                    if(yn == "y")
                    {
                        
                    }
                    else
                    {
                        break;
                    }

                }
            }
        }
        
        //Check if the user exists
        public User CheckUser(string username, string password)
        {
            List<User> u = new List<User>();
            for(int i=0; i< u.Count; i++)
            {
                if(username == u[i].uname && password == u[i].pass)
                {
                    
                    return u[i];
                }
            }
            return null;

        }
        
        ///<summery>
        /// Review Options
        /// </summery>
        public void ReviewOptions()
        {
            
        }
    }
}