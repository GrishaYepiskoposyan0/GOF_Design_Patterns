namespace GoF_Design_Patterns.Creational.FactoryMethod;

public class SmsNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification()
    {
        return new SmsNotification();
    }
}