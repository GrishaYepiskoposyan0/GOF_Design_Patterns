namespace GoF_Design_Patterns.Creational.FactoryMethod;

public class EmailNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification()
    {
        return new EmailNotification();
    }
}