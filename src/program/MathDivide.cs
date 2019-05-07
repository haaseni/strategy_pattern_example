namespace strategy_pattern_example
{
    public class MathDivide : IMathOperator
    {
        public int Calculate(int a, int b)
        {
            return a / b;
        }
    }
}
