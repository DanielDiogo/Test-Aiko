using Test_Aiko.Models;

namespace Test_Aiko.Interfaces
{
    public interface IStopRepository
    {
        Task<Stop> GetByIdAsync(long id);
        Task<List<Stop>> GetAllAsync();
        Task<Stop> CreateAsync(Stop stop);
        Task UpdateAsync(Stop stop);
        Task DeleteAsync(long id);
    }
}
