using CoffeeShopRegi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegi.Models
{
    public class Registration
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
