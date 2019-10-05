using MealVote.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MealVote.Infrastructure
{
    public interface IRestaurantRepository
    {
        public List<Restaurant> GetAllRestaurants(string cityOrZipCode);
    }
}
