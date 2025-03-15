namespace GoF_Design_Patterns.Creational.FactoryMethod;

public class SmsNotification: INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS Notification: {message}");
    }
}