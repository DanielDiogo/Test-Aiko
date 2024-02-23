using Test_Aiko.Interfaces;
namespace Test_Aiko.Controllers
{
    public class VehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        // Implement CRUD operations here...
    }
}
