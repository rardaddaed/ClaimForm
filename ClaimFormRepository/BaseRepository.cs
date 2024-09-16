using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SAOCPSEDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClaimFormRepository
{
    public abstract class BaseRepository
    {
        protected readonly SbcDbContext DbContext;
        private readonly IMapper Mapper;
        protected BaseRepository(SbcDbContext dbContext, IMapper mapper)
        {
            this.DbContext = dbContext;
            this.Mapper = mapper;
        }

        public async Task AddModelAsync<TModel, TDto>(DbSet<TModel> dbSet, TDto dto) where TModel : class
        {
            var model = Mapper.Map<TDto, TModel>(dto);
            if (model != null)
                dbSet.Add(model);

            await DbContext.SaveChangesAsync();
        }
    }
}
