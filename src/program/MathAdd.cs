namespace strategy_pattern_example
{
    public class MathSubtract : IMathOperator
    {
        public int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}
