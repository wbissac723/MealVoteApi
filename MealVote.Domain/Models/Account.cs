using System;

namespace MealVote.Domain
{
    public class Account
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime AccountCreatedDate { get; set; }
    }
}
