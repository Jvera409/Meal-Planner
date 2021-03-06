using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string RecipeDescription { get; set; }
        public string RecipeInstructions { get; set; }
        public int UserId { get; set; }


        public List<Ingredient> Ingredients { get; set; }

    }
}
