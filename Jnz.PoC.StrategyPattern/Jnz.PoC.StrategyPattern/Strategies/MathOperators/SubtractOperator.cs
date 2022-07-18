using Jnz.PoC.StrategyPattern.Strategies.Math;

namespace Jnz.PoC.StrategyPattern.Strategies.MathOperators
{
    public class SubtractOperator : IMathOperator
    {
        public Operator Operator => Operator.Subtract;
        public int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}
