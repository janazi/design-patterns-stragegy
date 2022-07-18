using Jnz.PoC.StrategyPattern.Strategies.Math;

namespace Jnz.PoC.StrategyPattern.Strategies.MathOperators
{
    public class AddOperator : IMathOperator
    {
        public Operator Operator => Operator.Add;
        public int Calculate(int a, int b)
        {
            return a + b;
        }
    }
}
