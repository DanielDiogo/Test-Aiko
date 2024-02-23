using Microsoft.EntityFrameworkCore;
using Test_Aiko.Data;
using Test_Aiko.Interfaces;
using Test_Aiko.Models;

namespace Test_Aiko.Repositories
{
    public class LineRepository : ILineRepository
    {
        private readonly ApplicationDbContext _context;

        public LineRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Line>> GetAllAsync()
        {
            return await _context.Lines.ToListAsync();
        }

        public async Task<Line> GetByIdAsync(long id)
        {
            return await _context.Lines.FindAsync(id);
        }

        public async Task<Line> CreateAsync(Line line)
        {
            _context.Lines.Add(line);
            await _context.SaveChangesAsync();
            return line;
        }

        public async Task UpdateAsync(Line line)
        {
            _context.Entry(line).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var line = await _context.Lines.FindAsync(id);
            if (line != null)
            {
                _context.Lines.Remove(line);
                await _context.SaveChangesAsync();
            }
        }
    }
}

