using Test_Aiko.Models;

namespace Test_Aiko.Interfaces
{
    public interface IVehiclePositionRepository
    {
        Task<VehiclePosition> GetByVehicleIdAsync(long vehicleId);
        Task<List<VehiclePosition>> GetAllAsync();
        Task<VehiclePosition> CreateAsync(VehiclePosition vehiclePosition);
        Task UpdateAsync(VehiclePosition vehiclePosition);
        Task DeleteByVehicleIdAsync(long vehicleId);
    }
}
