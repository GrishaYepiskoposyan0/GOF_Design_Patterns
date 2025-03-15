namespace GoF_Design_Patterns.Creational.FactoryMethod;

public class PushNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification()
    {
        return new PushNotification();
    }
}