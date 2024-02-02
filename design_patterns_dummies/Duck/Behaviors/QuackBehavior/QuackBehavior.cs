namespace design_patterns_dummies.Models.Behaviors.QuackBehaviors;

public class QuackBehavior : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quacked");
    }
}