using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace dir_watch_transfer_ui.DB
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        public DirWatchTransferContext Context
        {
            get
            {
                return new DirWatchTransferContext();
            }
        }

        public DbSet<TEntity> Table
        {
            get
            {
                return this.Context.Set<TEntity>();
            }
        }

        public async Task AddAsync(TEntity entity)
        {
            try
            {
                this.Table.Add(entity);
                await this.Context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            try
            {
                await this.Context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await this.Table.FirstOrDefaultAsync(expression);
        }

        public async Task<List<TEntity>> ToListAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await this.Table.Where(expression).ToListAsync();
        }

        public async Task<List<TEntity>> ListAllAsync()
        {
            return await this.Table.ToListAsync();
        }
    }
}
