using Test_Aiko.Models;

namespace Test_Aiko.Interfaces
{
    public interface ILineRepository
    {
        Task<Line> GetByIdAsync(long id);
        Task<List<Line>> GetAllAsync();
        Task<Line> CreateAsync(Line line);
        Task UpdateAsync(Line line);
        Task DeleteAsync(long id);
    }
}
