namespace FinanceTracker.Models
{
    public static class CategoriesRepository
    {
        private static readonly List<Category> _categories =
        [
            new() {CategoryId=1, Name="Beverage", Description="Beverage"},
            new() {CategoryId=2, Name="Bakery", Description="Bakery"},
            new() {CategoryId=3, Name="Meat", Description="Meat"}
        ];

        public static void AddCategory(Category category)
        {
            var maxId = _categories.Count;
            category.CategoryId = maxId + 1;
            _categories.Add(category);
        }

        public static List<Category> GetCategories() => _categories;

        public static Category? GetCategoryById(int id)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == id);
            if (category == null)
            {
                return null;
            }

            // cloned bcz that kind of mimics the actual DB
            return new Category { CategoryId = category.CategoryId, Description = category.Description, Name = category.Name };
        }

        public static void UpdateCategory(int id, Category category)
        {
            var oldCategory = _categories.FirstOrDefault(x => x.CategoryId == id);
            if (oldCategory != null)
            {
                oldCategory.Description = category.Description;
                oldCategory.Name = category.Name;   
            }
        }

        public static void DeleteCategory(int id)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId==id);
            if(category != null)
            {
                _categories.Remove(category);
            }
        }
    }
}
