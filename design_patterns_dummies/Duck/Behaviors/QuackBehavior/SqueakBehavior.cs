namespace design_patterns_dummies.Models.Behaviors.QuackBehaviors;

public class SqueakBehavior : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}