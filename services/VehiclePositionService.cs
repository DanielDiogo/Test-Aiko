using Test_Aiko.Interfaces;
using Test_Aiko.Models;

namespace Test_Aiko.services
{
    public class VehiclePositionService
    {
        private readonly IVehiclePositionRepository _vehiclePositionRepository;

        public VehiclePositionService(IVehiclePositionRepository vehiclePositionRepository)
        {
            _vehiclePositionRepository = vehiclePositionRepository;
        }

        public async Task<VehiclePosition> GetByVehicleIdAsync(long vehicleId)
        {
            return await _vehiclePositionRepository.GetByVehicleIdAsync(vehicleId);
        }

        public async Task<List<VehiclePosition>> GetAllAsync()
        {
            return await _vehiclePositionRepository.GetAllAsync();
        }

        public async Task<VehiclePosition> CreateAsync(VehiclePosition vehiclePosition)
        {
            return await _vehiclePositionRepository.CreateAsync(vehiclePosition);
        }

        public async Task UpdateAsync(VehiclePosition vehiclePosition)
        {
            await _vehiclePositionRepository.UpdateAsync(vehiclePosition);
        }

        public async Task DeleteByVehicleIdAsync(long vehicleId)
        {
            await _vehiclePositionRepository.DeleteByVehicleIdAsync(vehicleId);
        }
    }
}
