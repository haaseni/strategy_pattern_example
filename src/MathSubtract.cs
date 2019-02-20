namespace strategy_pattern_example
{
    public class MathAdd : IMathOperator
    {
        public int Operation(int a, int b)
        {
            return a + b;
        }
    }
}
