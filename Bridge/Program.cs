//// The Abstraction defines the interface for the "control" part of the two
//// class hierarchies. It maintains a reference to an object of the
//// Implementation hierarchy and delegates all of the real work to this
//// object.
//internal class Abstraction
//{
//    protected IImplementation _implementation;

//    public Abstraction(IImplementation implementation)
//    {
//        this._implementation = implementation;
//    }

//    public virtual string Operation()
//    {
//        return "Abstract: Base operation with:\n" +
//            _implementation.OperationImplementation();
//    }
//}

//// You can extend the Abstraction without changing the Implementation
//// classes.
//internal class ExtendedAbstraction : Abstraction
//{
//    public ExtendedAbstraction(IImplementation implementation) : base( implementation )
//    {
//    }

//    public override string Operation()
//    {
//        return "ExtendedAbstraction: Extended operation with:\n" +
//            base._implementation.OperationImplementation();
//    }
//}

//// The Implementation defines the interface for all implementation classes.
//// It doesn't have to match the Abstraction's interface. In fact, the two
//// interfaces can be entirely different. Typically the Implementation
//// interface provides only primitive operations, while the Abstraction
//// defines higher- level operations based on those primitives.
//public interface IImplementation
//{
//    string OperationImplementation();
//}

//// Each Concrete Implementation corresponds to a specific platform and
//// implements the Implementation interface using that platform's API.
//internal class ConcreteImplementationA : IImplementation
//{
//    public string OperationImplementation()
//    {
//        return "ConcreteImplementationA: The result in platform A.\n";
//    }
//}

//internal class ConcreteImplementationB : IImplementation
//{
//    public string OperationImplementation()
//    {
//        return "ConcreteImplementationA: The result in platform B.\n";
//    }
//}

//internal class Client
//{
//    // Except for the initialization phase, where an Abstraction object gets
//    // linked with a specific Implementation object, the client code should
//    // only depend on the Abstraction class. This way the client code can
//    // support any abstraction-implementation combination.
//    public void ClientCode(Abstraction abstraction)
//    {
//        Console.Write( abstraction.Operation() );
//    }
//}

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Client client = new Client();

//        Abstraction abstraction;
//        // The client code should be able to work with any pre-configured
//        // abstraction-implementation combination.
//        abstraction = new Abstraction( new ConcreteImplementationA() );
//        client.ClientCode( abstraction );

//        Console.WriteLine();

//        abstraction = new ExtendedAbstraction( new ConcreteImplementationB() );
//        client.ClientCode( abstraction );
//    }
//}

/// <summary>
/// Code above is example from refactoring.guru, below is my own
/// </summary>
///

public interface ITelevision
{
    public string Name { get; set; }
    int Channel { get; set; }

    void CheckChannel(int channel);

    void ChangeChannel(int channel);
}

public class TvLg : ITelevision
{
    public TvLg()
    {
        this.Channel = 1;
        this.Name = "LG";
    }

    public int Channel { get; set; }
    public string Name { get; set; }

    public void TurnOn()
    {
        Console.WriteLine($"Tv {Name} - I'm turning on.");
    }

    public void TurnOff()
    {
        Console.WriteLine($"Tv {Name} - I'm turning off");
    }

    public void ChangeChannel(int channel)
    {
        Channel = Channel;
        Console.WriteLine($"Tv {Name} - changing channel: {Channel}");
    }

    public void CheckChannel(int channel)
    {
        Console.WriteLine($"Check channel -  current channel: {Channel}");
    }
}

public class TvXiaomi : ITelevision
{
    public TvXiaomi()
    {
        this.Channel = 1;
        this.Name = "Xiaomi";
    }

    public void TurnOn()
    {
        Console.WriteLine($"Tv {Name} is turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine($"Tv {Name} is turned off");
    }

    public int Channel { get; set; }
    public string Name { get; set; }

    public void CheckChannel(int Channel)
    {
        Console.WriteLine($"Checking channel - current channel: {Channel}");
    }

    public void ChangeChannel(int Channel)
    {
        Channel = Channel;
        Console.WriteLine($"Tv {Name} - changing channel: {Channel}");
    }
}

public abstract class AbstractRemote
{
    private ITelevision tv;

    public AbstractRemote(ITelevision tv)
    {
        this.tv = tv;
    }

    public void TurnOn()
    {
        Console.WriteLine($"Tv {tv.Name} - I'm turning on.");
    }

    public void TurnOff()
    {
        Console.WriteLine($"Tv {tv.Name} - I'm turning off.");
    }

    public void CheckChannel()
    {
        Console.WriteLine($"Checking channel - current channel: {tv.Channel}");
    }

    public void ChangeChannel(int Channel)
    {
        tv.Channel = Channel;
        Console.WriteLine($"Tv {tv.Name} - changing channel: {Channel}");
    }
}

public class HarmonyRemote : AbstractRemote
{
    public HarmonyRemote(ITelevision tv) : base(tv)
    {
    }

    public void DoTurnOff()
    {
        Console.WriteLine("The Harmony remote is turning off the tv...");
        TurnOff();
    }

    public void DoTurnOn()
    {
        Console.WriteLine("The The Harmony remote is turning on the tv...");
        TurnOn();
    }

    public void DoChangeChannel(int Channel)
    {
        Console.WriteLine("The Harmony remote is checking channel...");
        ChangeChannel(Channel);
    }
}

public class PhilipsRemote : AbstractRemote
{
    public PhilipsRemote(ITelevision tv) : base(tv)
    {
    }

    public void DoTurnOff()
    {
        Console.WriteLine("The Philips remote is turning off the tv...");
        TurnOff();
    }

    public void DoTurnOn()
    {
        Console.WriteLine("The Philips remote is turning on the tv...");
        TurnOn();
    }

    public void DoChangeChannel(int Channel)
    {
        Console.WriteLine("The Philips remote is checking channel...");
        ChangeChannel(Channel);
    }
}

public class LgRemote : AbstractRemote
{
    public LgRemote(ITelevision tv) : base(tv)
    {
    }

    public void DoTurnOff()
    {
        Console.WriteLine("The Lg remote is turning off the tv...");
        TurnOff();
    }

    public void DoTurnOn()
    {
        Console.WriteLine("The Lg remote is turning on the tv...");
        TurnOn();
    }

    public void DoChangeChannel(int Channel)
    {
        Console.WriteLine("The Lg remote is checking channel...");
        ChangeChannel(Channel);
    }
}

internal class MainClass
{
    public static void Main(string[] args)
    {
        ITelevision tv = new TvLg();

        HarmonyRemote HarmonyRemote = new HarmonyRemote(tv);
        PhilipsRemote PhilipsRemote = new PhilipsRemote(tv);
        LgRemote LgRemote = new LgRemote(tv);

        HarmonyRemote.DoTurnOn();
        Console.WriteLine();
        HarmonyRemote.CheckChannel();
        Console.WriteLine();
        LgRemote.DoChangeChannel(100);
        Console.WriteLine();
        HarmonyRemote.CheckChannel();

        Console.WriteLine();

        HarmonyRemote.DoTurnOff();
    }
}