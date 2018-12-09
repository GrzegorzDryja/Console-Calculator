using Kalkulator.Operations;

namespace Kalkulator.Calculator
{
    class Calculator : ICalculator
    {
        private IBasicOperationService _basicOperationService;

        public Calculator(IBasicOperationService basicOperationService)
        {
            _basicOperationService = basicOperationService;
        }

        public float Add(float a, float b)
        {
            return _basicOperationService.Addition(a, b);
        }
    }
}
