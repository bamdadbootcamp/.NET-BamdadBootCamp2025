using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core;

namespace BookStore.Domain.Entities
{
    public class Language : BaseEntity
    {
        public string Name { get; private set; }
        public ICollection<Book> Books { get; private set; } = new List<Book>();
        public static Language Create(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Category name cannot be empty.", nameof(name));
            return new Language {
                Name = name,
                CreateDate = DateTime.Now,
            
            };
        }
        public static void Update(Language language, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Category name cannot be empty.", nameof(name));
            language.Name = name;
            language.UpdateDate = DateTime.Now;
        }
    }
}
