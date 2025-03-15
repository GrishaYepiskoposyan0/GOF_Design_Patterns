namespace GoF_Design_Patterns.Creational.FactoryMethod;

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Email message: {message}");
    }
}