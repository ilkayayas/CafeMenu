using CafeMenu.Data.Dto;
using CafeMenu.Data.Entities;

namespace CafeMenu.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllAsync();
        Task<IEnumerable<CategoryDto>> GetAllTreeAsync();
        Task<Category> Create(CategoryDto category);
        Task<Category?> Delete(int categoryId = 0);

        Task<Category?> Get(int categoryId = 0);
    }
}
