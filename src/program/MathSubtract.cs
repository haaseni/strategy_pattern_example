namespace strategy_pattern_example
{
    public class MathAdd : IMathOperator
    {
        public int Calculate(int a, int b)
        {
            return a + b;
        }
    }
}
