namespace Jnz.PoC.StrategyPattern.Strategies.Math
{
    public interface IMathOperator
    {
        Operator Operator { get; }
        int Calculate(int a, int b);
    }
}
