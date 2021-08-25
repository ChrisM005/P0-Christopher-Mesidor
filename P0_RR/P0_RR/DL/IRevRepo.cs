using System.Collections.Generic;
using Models;

namespace DL
{
    public interface IRevRepo
    {
        List<Models.Restaurant> GetAllRestaurants();
        List<Models.User> GetAllUsers();
        List<Models.Reviews> GetAllReviews();
        /*List<User> GetAllCats();
        Cat AddACat(Cat cat);
        Meal AddAMeal(Meal meal);
        Cat SearchCatByName(string name);*/
        //List<Meal> GetMealsByCatId(int catId);
        //void DeleteACat(Cat cat);
    }
}