using System;
using System.Collections.Generic;

namespace MyRecipe.Models
{
    public interface IRecipeRepository
    {
        IEnumerable<Recipe> GetAllRecipes();
        Recipe GetRecipeById(int Id);
    }
}
