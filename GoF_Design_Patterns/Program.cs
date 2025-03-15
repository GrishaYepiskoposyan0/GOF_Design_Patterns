using GoF_Design_Patterns.Creational.AbstractFactory;
using GoF_Design_Patterns.Creational.FactoryMethod;

public class Program
{
    static void Main(string[] args)
    {
        NotificationCreator emailCreator = new EmailNotificationCreator();
        emailCreator.Notify("my message");
        
        IDeviceFactory appleFactory = new AppleFactory();
        IDevice appleMobile = appleFactory.CreateMobile();
        appleMobile.GetDetails();
    }
}