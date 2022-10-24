using Azure;
using RecipesApp.Application.DTOs.EntityDTOs;
using RecipesApp.Application.DTOs.ResponseDTOs;
using RecipesApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.Interfaces.IService
{
    public interface IGenericService<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetByIdAsync(int id);

        IQueryable<TEntity> GetAllAsync();

        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression);

        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression);

        Task<TEntity> AddAsync(TEntity tEntity);

        Task<IQueryable<TEntity>> AddRangeAsync(IQueryable<TEntity> tEntity);

        Task Update(TEntity tEntity);

        Task Remove(TEntity tEntity);

        Task RemoveRange(IQueryable<TEntity> tEntity);
    }
}
