using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace dir_watch_transfer_web.DB
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        private DirWatchTransferContext context { get; set; }
        public DirWatchTransferContext Context
        {
            get
            {
                if (context == null)
                {
                    this.context = new DirWatchTransferContext();
                }

                return context;
            }
        }

        public DbSet<TEntity> Table
        {
            get
            {
                return this.Context.Set<TEntity>();
            }
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            try
            {
                this.Context.Entry(entity).State = EntityState.Added;
                await this.Table.AddAsync(entity);
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
                this.Context.Entry(entity).State = EntityState.Modified;
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
