namespace XPlanUnittest.App
{
    public class CalculatorService : ICalculatorService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }
    }
}
