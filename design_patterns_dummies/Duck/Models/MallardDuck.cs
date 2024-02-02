using design_patterns_dummies.Models.Behaviors.FlyingBehavior;
using design_patterns_dummies.Models.Behaviors.QuackBehaviors;

namespace design_patterns_dummies.Duck.Models;

public class MallardDuck : Duck
{
    public MallardDuck(string name) : base(name, new QuackBehavior(), new FlyWithWingsBehavior())
    {
    }
}