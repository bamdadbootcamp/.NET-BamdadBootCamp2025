using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core;

namespace BookStore.Domain.Entities
{
    public class Category :BaseEntity
    {
        public string Name { get; private set; }
        public ICollection<Book> Books { get; private set; } = new List<Book>();

        public static Category Create(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Category name cannot be empty.", nameof(name));
            return new Category
            {
                Name = name,
                CreateDate = DateTime.Now
            };
        }
        public static void Update(Category category, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Category name cannot be empty.", nameof(name));
            category.Name = name;  
            category.UpdateDate = DateTime.Now;
        }

       
    }
}
