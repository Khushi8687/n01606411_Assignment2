using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01606411_Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public IHttpActionResult tolalCal(int burger, int drink, int side, int dessert)
        {
            int[] burgerCalories = { 0, 461, 431, 420 };
            int[] drinkCalories = { 0, 130, 160, 118 };
            int[] sideCalories = { 0, 100, 57, 70 };
            int[] dessertCalories = { 0, 167, 266, 75 };
            int totalCalories = burgerCalories[burger] + drinkCalories[drink] + sideCalories[side] + dessertCalories[dessert];
            return Ok("Your total calorie count is " + totalCalories + " Calories.");
        }
    }
}
