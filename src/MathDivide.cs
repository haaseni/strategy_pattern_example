namespace strategy_pattern_example
{
    public class MathDivide : IMathOperator
    {
        public int Operation(int a, int b)
        {
            return a / b;
        }
    }
}
