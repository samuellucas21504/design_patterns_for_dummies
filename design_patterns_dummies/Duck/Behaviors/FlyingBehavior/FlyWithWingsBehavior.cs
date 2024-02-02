namespace design_patterns_dummies.Models.Behaviors.FlyingBehavior;

public class FlyWithWingsBehavior : IFlyBehavior
{
    public void Fly(string name)
    {
        Console.WriteLine($"{name} is flying with his wings");
    }
}