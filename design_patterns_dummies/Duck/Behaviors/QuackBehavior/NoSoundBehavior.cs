namespace design_patterns_dummies.Models.Behaviors.QuackBehaviors;

public class NoSoundBehavior : IQuackBehavior
{
    public void Quack(string name)
    {
        Console.WriteLine($"{name} makes no sound");
    } 
}