using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Application.DTOs.EntityDTOs;
using RecipesApp.Application.DTOs.CustomResponseDTOs;
using RecipesApp.Application.Filters;
using RecipesApp.Application.Interfaces.IService;
using RecipesApp.Domain.Entities;

namespace RecipesApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRecipeService _recipeService;
        private readonly ILogger<RecipeController> _logger;

        public RecipeController(IRecipeService recipeService, IMapper mapper, ILogger<RecipeController> logger)
        {
            _recipeService = recipeService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> RecipeAll()
        {
            var recipes = await _recipeService.GetRecipeAll();
            var recipesDto = _mapper.Map<List<RecipeDto>>(recipes);
            return Ok(ResponseDto<List<RecipeDto>>.Success(recipesDto, 200));
        }


        [ServiceFilter(typeof(NotFoundFilter<Recipe>))]
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var recipe = await _recipeService.GetRecipeById(id);
            var recipeDto = _mapper.Map<RecipeDto>(recipe);
            return Ok(ResponseDto<RecipeDto>.Success(recipeDto, 200));
        }

        [HttpPost]
        public async Task<IActionResult> RecipeAdd(AddRecipeDto addRecipeDto)
        {
            var recipe = await _recipeService.AddAsync(_mapper.Map<Recipe>(addRecipeDto));
            var recipeDto = _mapper.Map<AddRecipeDto>(recipe);
            return Ok(ResponseDto<AddRecipeDto>.Success(recipeDto, 200));
        }






    }
}


