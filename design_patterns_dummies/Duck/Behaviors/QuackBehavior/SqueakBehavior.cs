namespace design_patterns_dummies.Models.Behaviors.QuackBehaviors;

public class SqueakBehavior : IQuackBehavior
{
    public void Quack(string name)
    {
        Console.WriteLine($"{name} squeaked");
    }
}