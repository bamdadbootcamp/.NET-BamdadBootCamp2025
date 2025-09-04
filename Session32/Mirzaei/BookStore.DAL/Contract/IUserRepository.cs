﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Entities;

namespace BookStore.DAL.Contract;

public interface IUserRepository : IRepository<User>
{
}
