using System.ComponentModel.DataAnnotations.Schema;

namespace CafeMenu.Data.Dto
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public required string CategoryName { get; set; }
        public int ParentCategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatorUserId { get; set; }
    }
}
