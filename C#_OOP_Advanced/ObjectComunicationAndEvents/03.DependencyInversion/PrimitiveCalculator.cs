using System.Collections.Generic;

public class PrimitiveCalculator
{
    private IStrategy strategy;

    private Dictionary<char, IStrategy> strategies = new Dictionary<char, IStrategy>()
    {
        {'+',new AdditionStrategy() },
        {'-',new SubtractionStrategy() },
        {'*',new MultiplyStrategy() },
        {'/',new DevideStrategy() }
    };

    public PrimitiveCalculator()
    {
        this.strategy = this.strategies['+'];

    }

    public void ChangeStrategy(char @operator)
    {
        this.strategy = this.strategies[@operator];
    }

    public int PerformCalculation(int firstOperand, int secondOperand)
    {
        return this.strategy.Calculate(firstOperand, secondOperand);
    }
}

