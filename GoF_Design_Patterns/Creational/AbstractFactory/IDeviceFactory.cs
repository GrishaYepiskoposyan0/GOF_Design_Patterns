namespace GoF_Design_Patterns.Creational.AbstractFactory;

public interface IDeviceFactory
{
    IDevice CreateMobile();
    IDevice CreateLaptop();
}