using System;
using System.Collections.Generic;
using MealVote.Domain;

namespace MealVote.Infrastructure
{
    public class RestaurantRepository : IRestaurantRepository
    {
        public List<Restaurant> GetAllRestaurants(string cityOrZipCode)
        {
            throw new NotImplementedException();
        }
    }
}
