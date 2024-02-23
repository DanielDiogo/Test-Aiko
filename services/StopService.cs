using Test_Aiko.Interfaces;

namespace Test_Aiko.Controllers
{
    public class StopService
    {
        private readonly IStopRepository _stopRepository;

        public StopService(IStopRepository stopRepository)
        {
            _stopRepository = stopRepository;
        }
    }
}
