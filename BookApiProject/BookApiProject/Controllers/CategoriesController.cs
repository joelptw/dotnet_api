using BookApiProject.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController:Controller
    {
        ICatergoryRepository _categoryRepository;

        public CategoriesController(ICatergoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        
        public IActionResult GetCategories()
        {
            var categories = _categoryRepository.GetCategories().ToList();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(categories);
        }
    }


}
