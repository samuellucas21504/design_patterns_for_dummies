namespace design_patterns_dummies.Models.Behaviors.FlyingBehavior;

public class NoFlyBehavior : IFlyBehavior
{
    public void Fly(string name)
    {
        Console.WriteLine($"{name} can't fly");
    }
}