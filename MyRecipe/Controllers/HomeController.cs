using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyRecipe.Models;
using MyRecipe.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyRecipe.Controllers
{
    //[Route("[Controller]/[action]")]
    public class HomeController : Controller
    {
        private IRecipeRepository _recipeRepository;
        private IFeedbackRepository _feedbackRepository;

        public HomeController(IRecipeRepository recipeRepository,IFeedbackRepository feedbackRepository)
        {
            _recipeRepository = recipeRepository;
            _feedbackRepository = feedbackRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            // var recipes = _recipeRepository.GetAllRecipes();
            var viewModle = new HomeViewModel()
            {
                Feedbacks = _feedbackRepository.GetAllFeedBacks().ToList(),
                Recipes = _recipeRepository.GetAllRecipes().ToList()
            };
            return View(viewModle);
        }

        public String About()
        {
            return "Hello from About";
        }

        public IActionResult Detail(int id)
        { 
            return View(_recipeRepository.GetRecipeById(id));
        }
    }
}
