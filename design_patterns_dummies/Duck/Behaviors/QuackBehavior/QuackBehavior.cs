namespace design_patterns_dummies.Models.Behaviors.QuackBehaviors;

public class QuackBehavior : IQuackBehavior
{
    public void Quack(string name)
    {
        Console.WriteLine($"{name} quacked");
    }
}