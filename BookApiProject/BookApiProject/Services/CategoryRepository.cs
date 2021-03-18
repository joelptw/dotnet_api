
using BookApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApiProject.Services
{
    public class CategoryRepository : ICatergoryRepository
    {
        private BookDbContext _categoryContext;
        public CategoryRepository(BookDbContext categoryContext)
        {
            _categoryContext = categoryContext;
        }

        public ICollection<Book> GetBooksForCategory(int categoryId)
        {
            return _categoryContext.BookCategories.Where(c => c.CategoryId == categoryId).Select(b =>b.Book).ToList();
        }

        public ICollection<Category> GetCategories()
        {
            return _categoryContext.Categories.ToList();
        }

        public ICollection<Category> GetCategoriesOfABook(int bookId)
        {
            return _categoryContext.BookCategories.Where(b => b.BookId == bookId).Select(c => c.Category).ToList();
        }

        public Category GetCategory(int categoryId)
        {
            return _categoryContext.Categories.Where(c => c.Id==categoryId).FirstOrDefault(); 
        }
    }
}
