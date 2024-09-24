
namespace Calculator.Services
{
    public class CalculatorImp
    {
        public float Sum(float n1, float n2)
        {
            return n1 + n2;
        }

        public bool IsPair(int n)
        {
            return n % 2 == 0;
        }
    }
}