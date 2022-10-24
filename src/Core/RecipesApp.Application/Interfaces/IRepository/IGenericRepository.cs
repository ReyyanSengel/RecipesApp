﻿using RecipesApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.Interfaces.IRepository
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetByIdAsync(int id);

        IQueryable<TEntity> GetAllAsync();

        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression);

        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression);

        Task AddAsync(TEntity entity);

        Task AddRangeAsync(IQueryable<TEntity> entities);

        void Update(TEntity entity);

        void Remove(TEntity entity);

        void RemoveRange(IQueryable<TEntity> entities);
    }
}
