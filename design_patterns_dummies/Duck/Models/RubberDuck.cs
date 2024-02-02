using design_patterns_dummies.Models.Behaviors.FlyingBehavior;
using design_patterns_dummies.Models.Behaviors.QuackBehaviors;

namespace design_patterns_dummies.Duck.Models;

public class RubberDuck : Duck
{
    public RubberDuck(string name) : base(name, new SqueakBehavior(), new NoFlyBehavior())
    {
    }
}