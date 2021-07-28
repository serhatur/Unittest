namespace XPlanUnittest.App
{
    public class Calculator
    {
        private ICalculatorService _calculatorService;
        public Calculator(ICalculatorService calculatorService)
        {
            this._calculatorService = calculatorService;
        }

        public int Add(int a,int b)
        {
            return _calculatorService.Add(a, b);
        }

        public int Multiplication(int a, int b)
        {
            return _calculatorService.Multiplication(a, b);
        }
    }
}
