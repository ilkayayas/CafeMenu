using AutoMapper;
using CafeMenu.Data.Dto;
using CafeMenu.Models;
using CafeMenu.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CafeMenu.Controllers
{
    [Route("category")]
    public class CategoryController : Controller
    {

        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet("list")]
        public async Task<IActionResult> List()
        {
            var categories = await _categoryService.GetAllAsync();
            var categoriesModel = _mapper.Map<IEnumerable<CategoryModel>>(categories);
            return View(categoriesModel);
        }

        [HttpGet("addnew")]
        public async Task<IActionResult> AddNew()
        {
            var categories = await _categoryService.GetAllTreeAsync();
            ViewBag.Categories = _mapper.Map<IEnumerable<CategoryModel>>(categories);

            return View();
        }

        [HttpPost("addnew")]
        public async Task<IActionResult> AddNew(CategoryDto categoryDto)
        {
            categoryDto.CreatedDate = DateTime.Now;
            categoryDto.CreatorUserId = 1;

            if (ModelState.IsValid)
            {
                var category = await _categoryService.Create(categoryDto);
                return RedirectToAction("AddNew");
            }
            return View(categoryDto);
        }

        [HttpGet("edit/{categoryId:int?}")]
        public async Task<IActionResult> Edit(int categoryId = 0)
        {
            var categories = await _categoryService.GetAllTreeAsync();
            ViewBag.Categories = _mapper.Map<IEnumerable<CategoryModel>>(categories);

            var category = await _categoryService.Get(categoryId);
            return View(_mapper.Map<CategoryModel>(category));
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(int categoryId = 0)
        {
            var category = await _categoryService.Delete(categoryId);
            return RedirectToAction("List");
        }
    }
}
