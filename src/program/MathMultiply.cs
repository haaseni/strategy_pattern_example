namespace strategy_pattern_example
{
    public class MathMultiply : IMathOperator
    {
        public int Calculate(int a, int b)
        {
            return a * b;
        }
    }
}
