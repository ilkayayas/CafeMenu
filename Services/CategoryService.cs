using AutoMapper;
using CafeMenu.Data;
using CafeMenu.Data.Dto;
using CafeMenu.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CafeMenu.Services
{
    public class CategoryService: ICategoryService
    {

        private readonly CafeMenuDbContext _context;
        private readonly IMapper _mapper;

        public CategoryService(CafeMenuDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            var categories = await _context.Categories.Where(u => u.IsDeleted == false).OrderBy(u => u.CategoryId).ToListAsync();
            return _mapper.Map<List<CategoryDto>>(categories);
        }


        public async Task<IEnumerable<CategoryDto>> GetAllTreeAsync()
        {
            var categories = await _context.Categories.Where(u => u.IsDeleted == false).OrderBy(u => u.CategoryId).ToListAsync();

            var categoriesTree = new List<CategoryDto>();
            var lookup = categories.ToLookup(c => c.ParentCategoryId == 0 ? (int?)null : c.ParentCategoryId);

            void BuildCategoryTree(int? parentId, int level)
            {
                foreach (var category in lookup[parentId])
                {
                    var categoryDto = new CategoryDto
                    {
                        CategoryId = category.CategoryId,
                        CategoryName = new string('-', level) + " " + category.CategoryName,
                        ParentCategoryId = category.ParentCategoryId,
                        IsDeleted = category.IsDeleted,
                        CreatedDate = category.CreatedDate,
                        CreatorUserId = category.CreatorUserId
                    };
                    categoriesTree.Add(categoryDto);
                    BuildCategoryTree(category.CategoryId, level + 1);
                }
            }

            BuildCategoryTree(null, 0);
            return categoriesTree;
        }


        public async Task<Category> Create(CategoryDto categoryDto)
        {
            if (categoryDto == null)
            {
                throw new ArgumentNullException(nameof(categoryDto));
            }

            var categoryEntity = _mapper.Map<Category>(categoryDto);

            await _context.Categories.AddAsync(categoryEntity);
            await _context.SaveChangesAsync();
            return categoryEntity;
        }


        public async Task<Category?> Get(int categoryId = 0)
        {
            if (categoryId > 0)
            {
                var category = await _context.Categories.Where(u => u.CategoryId == categoryId).FirstOrDefaultAsync();
                return category;
            }
            return null;
        }


        public async Task<Category?> Delete(int categoryId = 0)
        {
            if (categoryId > 0)
            {
                var category = await _context.Categories.Where(u => u.CategoryId == categoryId).FirstOrDefaultAsync();
                if (category != null)
                {
                    category.IsDeleted = true;
                    await _context.SaveChangesAsync();
                    return category;
                }
            }
            return null;
        }




    }
}
