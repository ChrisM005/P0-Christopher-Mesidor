using Models;
using DL.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace DL
{
    public class RevRepo : IRevRepo
    {
        private CMDBP0Context _context;
        public RevRepo(CMDBP0Context context)
        {
            _context = context;
        }

        public List<Models.Restaurant> GetAllRestaurants()
        {
            return _context.Restaurant.Select(
                restaurant => new Models.Restaurant(restaurant.ID, restaurant.Name, restaurant.Rating, restaurant.location, restaurant.ZipCode)
            ).ToList();
        }

        public List<Models.User> GetAllUsers()
        {
            return _context.User.Select(
                user => new Models.User(user.ID, user.Username, User.Password, User.Admin)
            ).ToList();
        }

        public List<Models.Reviews> GetAllReviews()
        {
            return _context.Reviews.Select(
                reviews => new Models.Restaurant(reviews.ID, reviews.Users, reviews.Restaurant, reviews.Rating, reviews.Comments)
            ).ToList();
        }

       /* public Models.Cat AddACat(Models.Cat cat)
        {
            _context.Cats.Add(
                new Entities.Cat{
                    Name = cat.Name
                }
            );
            _context.SaveChanges();

            return cat;
        }

        public Models.Meal AddAMeal(Models.Meal meal)
        {
            _context.Meals.Add(
                new Entities.Meal {
                    Time = meal.Time,
                    FoodType = meal.FoodType,
                    CatId = meal.CatId
                }
            );
            _context.SaveChanges();

            return meal;
        }

        public Models.Cat SearchCatByName(string name)
        {
            Entities.Cat foundCat =  _context.Cats
                .FirstOrDefault(cat => cat.Name == name);
            if(foundCat != null)
            {
                return new Models.Cat(foundCat.Id, foundCat.Name,foundCat.ribcage ,foundCat.leglength);
            }
            return new Models.Cat();
        }

        public List<Models.Meal> GetMealsByCatId(int catId)
        {
            Console.WriteLine("I'm in DL, getting meals by Id, {0}", catId);
            return _context.Meals
                .Where(meal => meal.CatId == catId)
                .Select(meal => new Models.Meal{
                    Time = meal.Time,
                    FoodType = meal.FoodType,
                    CatId = (int)meal.CatId
                })
                .ToList();
        }*/

        
    }
}