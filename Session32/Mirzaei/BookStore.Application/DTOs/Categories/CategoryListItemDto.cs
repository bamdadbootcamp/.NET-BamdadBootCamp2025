using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.DTOs.Categories
{
    public class CategoryListItemDto
    {
        public int Id { get; set; }          
        public string Name { get; set; }
        public int BooksCount { get; set; }
    }
}
