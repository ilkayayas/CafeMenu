namespace CafeMenu.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public required string CategoryName { get; set; }
        public int ParentCategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatorUserId { get; set; }
    }
}
