using System;
using System.Linq;

namespace MyRecipe.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (context.Recipes.Any())
            {
                return;
            }

            context.AddRange(
                new Recipe { Name = "Capillary", Price = 12, ShortDescription = "As thin as a hair", LongDescription = "Really so thin, so thin, so fine", ImageUrl = "/images/1.png" },
                new Recipe { Name = "fine", Price = 10, ShortDescription = "normal thin", LongDescription = "still very thin", ImageUrl = "/images/2.png" },
                new Recipe { Name = "Three Fine", Price = 11, ShortDescription = "A bit thicker", LongDescription = "Those thicker than thin, finer than second", ImageUrl = "/images/3.png" },
                new Recipe { Name = "Second Fine", Price = 10, ShortDescription = "Cold", LongDescription = "Cold is chewy", ImageUrl = "/images/4.png" },
                new Recipe { Name = "Two Thin", Price = 11, ShortDescription = "Too thick", LongDescription = "It's too thick to bite", ImageUrl = "/images/5.png" },
                new Recipe { Name = "Leek leaves", Price = 12, ShortDescription = "Flat", LongDescription = "Leaves are as wide as the leaves", ImageUrl = "/images/6.png" },
                new Recipe { Name = "thin and wide", Price = 11, ShortDescription = "beginning to be wider", LongDescription = "a little wider than the leek leaves, a little narrower than the big width", ImageUrl = "/images/7.png" },
                new Recipe { Name = "Large wide", Price = 10, ShortDescription = "Pants side", LongDescription = "Wide wider than the mouth", ImageUrl = "/images/8.png" },
                new Recipe { Name = "buckwheat ridge", Price = 15, ShortDescription = "cubic", LongDescription = "It seems to know how the master pulled it out", ImageUrl = "/images/9.png" },
                new Recipe { Name = "Yiwosi", Price = 15, ShortDescription = "What is this", LongDescription = "I haven't eaten either", ImageUrl = "/images/10.png" }
                );
            context.SaveChanges();
        }
    }
}
