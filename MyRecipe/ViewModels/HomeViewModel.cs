using System;
using System.Collections.Generic;
using MyRecipe.Models;
namespace MyRecipe.ViewModels
{
    public class HomeViewModel
    {

        public IList<Recipe> Recipes { get; set; }
        public IList<Feedback> Feedbacks { get; set; }


    }
}
