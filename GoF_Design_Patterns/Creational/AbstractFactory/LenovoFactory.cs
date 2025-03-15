namespace GoF_Design_Patterns.Creational.AbstractFactory;

public class LenovoFactory : IDeviceFactory
{
    public IDevice CreateMobile()
    {
        return new LenovoMobile();
    }
    
    public IDevice CreateLaptop()
    {
        return new LenovoLaptop();
    }
}