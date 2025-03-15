using GoF_Design_Patterns.Creational.AbstractFactory;
using GoF_Design_Patterns.Creational.FactoryMethod;
using GoF_Design_Patterns.Creational.Singleton;

public class Program
{
    static void Main(string[] args)
    {
        NotificationCreator emailCreator = new EmailNotificationCreator();
        emailCreator.Notify("my message");
        
        IDeviceFactory appleFactory = new AppleFactory();
        IDevice appleMobile = appleFactory.CreateMobile();
        appleMobile.GetDetails();
        
        ConfigurationManager configurationManager1 = ConfigurationManager.Instance;
        ConfigurationManager configurationManager2 = ConfigurationManager.Instance;

        if (configurationManager1 == configurationManager2)
        {
            Console.WriteLine("Both instances are the same.");
        }
    }
}