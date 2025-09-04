using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.DAL.Contexts;
using BookStore.DAL.Contract;
using BookStore.Domain.Entities;

namespace BookStore.DAL.Repositories
{
    public class LanguageRepository : Repository<Language>, ILanguageRepository
    {
        public LanguageRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
