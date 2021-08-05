﻿using Capstone.DAO.Interfaces;
using Capstone.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class PantryController : ControllerBase
    {
        private readonly IIngredientsDAO ingredientsDAO;
        private readonly IRecipeDAO recipeDAO;

        public PantryController(IIngredientsDAO ingredientsDAO)
        {
            this.ingredientsDAO = ingredientsDAO;
        }

        [HttpPost]
        public ActionResult<bool> AddNewIngredient(Ingredient ingredient)
        {

            bool result = ingredientsDAO.AddIngredient(ingredient);

            if (result)
            {
                return Ok(result);
            }
            else
            {
                return NotFound(result);
            }
        }

        [HttpGet("{userId}")]
        public ActionResult<List<Ingredient>> ListAllIngredients(int userId)
        {


            List<Ingredient> ingredients = ingredientsDAO.GetAllIngredients(userId);

            return Ok(ingredients);

            //return NotFound(ingredients);
        }


        [HttpPost]
        public ActionResult<bool> AddRecipe(Recipe recipe)
        {
            bool result = recipeDAO.Addrecipe(recipe);

            if (result) 
            {

                return Ok(result);
            }
            else
            {
                return NotFound(result);
            }
        }
    }
}
