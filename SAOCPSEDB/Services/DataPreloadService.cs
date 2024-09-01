using Microsoft.EntityFrameworkCore;
using SAOCPSEDB.Models;

namespace SAOCPSEDB.Services
{
    public interface IDataPreloadService
    {
        Task PreloadDataAsync();
    }

    public class DataPreloadService : IDataPreloadService
    {
        private readonly SbcDbContext _context;

        public DataPreloadService(SbcDbContext context)
        {
            _context = context;
        }

        public async Task PreloadDataAsync()
        {
            // Perform a query to load the data
            await _context.Zprimarycodes.Take(1).ToListAsync();
        }
    }
}
