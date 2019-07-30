﻿using Microsoft.EntityFrameworkCore;

namespace Sparrow.EntityFrameworkCore.Repositories
{
    public interface IRepositoryWithDbContext
    {
        DbContext GetDbContext();
    }
} 