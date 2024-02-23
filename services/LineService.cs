using Test_Aiko.Interfaces;

namespace Test_Aiko.Services
{
    public class LineService
    {
        private readonly ILineRepository _lineRepository;

        public LineService(ILineRepository lineRepository)
        {
            _lineRepository = lineRepository;
        }
    }
}
