using System;
using System.Collections.Generic;
using System.Linq;

namespace MyRecipe.Models
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly AppDbContext _context;

        public RecipeRepository(AppDbContext appDbContext)
        {

            _context = appDbContext;
        }

        public IEnumerable<Recipe> GetAllRecipes()
        {
            return _context.Recipes;
        }

        public Recipe GetRecipeById(int Id)
        {
            return _context.Recipes.FirstOrDefault(n => n.Id == Id);
        }
    }
}
