using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.DAL.Contexts;
using BookStore.Domain.Entities;

namespace BookStore.DAL.Repositories
{
    public class CategoryRepository : Repository<Category>
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
