namespace Jnz.PoC.StrategyPattern.Strategies.Math
{
    public class MathStrategy : IMathStrategy
    {
        private readonly IEnumerable<IMathOperator> _operators;

        public MathStrategy(IEnumerable<IMathOperator> operators)
        {
            _operators = operators;
        }
        public int Calculate(int a, int b, Operator op)
        {
            var mathOperator = _operators.FirstOrDefault(o => o.Operator == op);

            if (mathOperator == null)
                throw new ArgumentNullException(nameof(op));

            return mathOperator.Calculate(a, b);
        }
    }
}
