using Microsoft.EntityFrameworkCore;
using SoruApp.core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruApp.data
{
    public class UnitOfWork :IUnitOfWork
       
    
    {
        private readonly DbContext _dbContext;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;

        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
