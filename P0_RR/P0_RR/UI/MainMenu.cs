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
            //string rname;
            bool repeat = true;
            //Starting menu
            do
            {
                Console.WriteLine("Welcome to Resteraunt Reviewer!");
                Console.WriteLine("0) Exit Resterant Reviewer");
                Console.WriteLine("1) New User");
                Console.WriteLine("2) Current User");
                Console.WriteLine("3) Display List of Restaurants");
                Console.WriteLine("4) Search for a Restaurant");
               // Console.WriteLine("4) Search for a Resteraunt");
                //Console.WriteLine("5) Search for a Resteraunt");

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
                        ULogin();
                    break;
                    case "3":
                        DispResteraunt(res);                        
                    break;
                    case "4":
                        SearchResteraunt();
                    break;
                    default:
                        Console.WriteLine("Invalid input, try again.");
                    break;
                }
            } while(repeat);
        }

        //Create User
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

        //User Login
        public void ULogin()
        {
            string un;
            string pw;
            bool uvalid = false;
            bool pvalid = false;

            Console.WriteLine("Username: ");

            Console.WriteLine("Password: ");
        }

        //Display Restaurant
        public void DispResteraunt(List<Restaurant> r)
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
        public void DispUsers(List<User> r)
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
        public void DispReviews(List<Reviews> r)
        {
            r = new List<Reviews>();
            Console.WriteLine("--------------------------------");
            for(int i=0; i< r.Count; i++)
            {
                //Console.WriteLine($"User ID: {r[i].ID}");
                Console.WriteLine($"Username: {r[i].rating}");
                Console.WriteLine($"Password: {r[i].comment}");
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
                        Console.WriteLine("Enter your username: ");
                        usr = Console.ReadLine();
                        Console.WriteLine("Enter your password: ");
                        pw = Console.ReadLine();
                        
                        CheckUser(usr,pw);
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
        
        public void MakeReview()
        {
            InvalidCastException input=0;
            string comment = "";
            Reviews ReviewToAdd;

            Console.WriteLine("Enter Review to add out of 5: ");
            
            do
            {
                Console.WriteLine("Rate: ");
                input = Console.ReadLine();

            } while(int.IsNullOrWhiteSpace(input) && (input >0 && input <=5));

            Console.WriteLine("Comment: ");
            comment = Console.ReadLine();

            RevToAdd = new Reviews(input,comment);
            RevToAdd = _revbl.MakeReview(RevToAdd);

            Console.WriteLine("Review was successfully added!");
        }
        
    }
}