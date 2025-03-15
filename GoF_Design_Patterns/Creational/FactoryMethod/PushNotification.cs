namespace GoF_Design_Patterns.Creational.FactoryMethod;

public class PushNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Push Notification: {message}");
    }
}