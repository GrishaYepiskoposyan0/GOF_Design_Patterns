namespace GoF_Design_Patterns.Creational.AbstractFactory;

public class AppleFactory : IDeviceFactory
{
    public IDevice CreateMobile()
    {
        return new AppleMobile();
    }
    
    public IDevice CreateLaptop()
    {
        return new AppleLaptop();
    }
}