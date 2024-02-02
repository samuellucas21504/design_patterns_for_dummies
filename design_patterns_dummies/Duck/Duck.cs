using design_patterns_dummies.Models.Behaviors.FlyingBehavior;
using design_patterns_dummies.Models.Behaviors.QuackBehaviors;

namespace design_patterns_dummies.Duck;

public abstract class Duck
{
    private string _name;
    private readonly IQuackBehavior _quackBehavior;
    private readonly IFlyBehavior _flyBehavior;

    protected Duck(string name, IQuackBehavior quackBehavior, IFlyBehavior flyBehavior)
    {
        _name = name;
        _quackBehavior = quackBehavior;
        _flyBehavior = flyBehavior;
    }

    public void Quack()
    {
        _quackBehavior.Quack(_name);
    }

    public void Fly()
    {
        _flyBehavior.Fly(_name);
    }
}