using RecipesApp.Application.Interfaces.IUnitOfWork;
using RecipesApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RecipeAppDbContext _context;

        public UnitOfWork(RecipeAppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
