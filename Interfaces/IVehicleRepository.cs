using Test_Aiko.Models;

namespace Test_Aiko.Interfaces
{
    public interface IVehicleRepository
    {
        Task<Vehicle> GetByIdAsync(long id);
        Task<List<Vehicle>> GetAllAsync();
        Task<Vehicle> CreateAsync(Vehicle vehicle);
        Task UpdateAsync(Vehicle vehicle);
        Task DeleteAsync(long id);
    }
}
