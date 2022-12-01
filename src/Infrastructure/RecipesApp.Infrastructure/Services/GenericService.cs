using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Application.DTOs.EntityDTOs;
using RecipesApp.Application.DTOs.CustomResponseDTOs;
using RecipesApp.Application.Exceptions;
using RecipesApp.Application.Interfaces.IRepository;
using RecipesApp.Application.Interfaces.IService;
using RecipesApp.Application.Interfaces.IUnitOfWorks;
using RecipesApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Infrastructure.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        private readonly IGenericRepository<TEntity> _repository;

        private readonly IUnitOfWork _unitOfWork;

        public GenericService(IGenericRepository<TEntity> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;

        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public async Task<IQueryable<TEntity>> AddRangeAsync(IQueryable<TEntity> entities)
        {
            await _repository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            return entities;
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _repository.AnyAsync(expression);
        }

        public IQueryable<TEntity> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            var hasEntity = await _repository.GetByIdAsync(id);
            if (hasEntity == null)
            {
                throw new NotFoundException($"{typeof(TEntity).Name} ({id}) not found");
            }
            return hasEntity;
        }

        public async Task Remove(TEntity entity)
        {
            _repository.Remove(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveRange(IQueryable<TEntity> entities)
        {
            _repository.RemoveRange(entities);
            await _unitOfWork.CommitAsync();
        }

        public async Task Update(TEntity entity)
        {
            _repository.Update(entity);
            await _unitOfWork.CommitAsync();
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
        {
            return _repository.Where(expression);
        }
    }

}
