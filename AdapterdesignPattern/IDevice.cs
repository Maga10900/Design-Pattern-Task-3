namespace AdapterdesignPattern;

public interface IDevice
{
    void Work();
}

public class Mouse : IDevice
{
    public void Work()
    {
        //do something
    }
}
//Nugetden gelib
public class MouseNuget
{
    public void DoWork()
    {
        //do Something
    }
}

public class MouseNugetAdapter : IDevice
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}

