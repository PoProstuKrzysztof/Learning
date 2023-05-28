//// The base Component interface defines operations that can be altered by
//// decorators.
//public abstract class Component
//{
//    public abstract string Operation();
//}

//// Concrete Components provide default implementations of the operations.
//// There might be several variations of these classes.
//internal class ConcreteComponent : Component
//{
//    public override string Operation()
//    {
//        return "ConcreteComponent";
//    }
//}

//// The base Decorator class follows the same interface as the other
//// components. The primary purpose of this class is to define the wrapping
//// interface for all concrete decorators. The default implementation of the
//// wrapping code might include a field for storing a wrapped component and
//// the means to initialize it.
//internal abstract class Decorator : Component
//{
//    protected Component _component;

//    public Decorator(Component component)
//    {
//        this._component = component;
//    }

//    public void SetComponent(Component component)
//    {
//        this._component = component;
//    }

//    // The Decorator delegates all work to the wrapped component.
//    public override string Operation()
//    {
//        if (this._component != null)
//        {
//            return this._component.Operation();
//        }
//        else
//        {
//            return string.Empty;
//        }
//    }
//}

//// Concrete Decorators call the wrapped object and alter its result in some
//// way.
//internal class ConcreteDecoratorA : Decorator
//{
//    public ConcreteDecoratorA(Component comp) : base(comp)
//    {
//    }

//    // Decorators may call parent implementation of the operation, instead
//    // of calling the wrapped object directly. This approach simplifies
//    // extension of decorator classes.
//    public override string Operation()
//    {
//        return $"ConcreteDecoratorA({base.Operation()})";
//    }
//}

//// Decorators can execute their behavior either before or after the call to
//// a wrapped object.
//internal class ConcreteDecoratorB : Decorator
//{
//    public ConcreteDecoratorB(Component comp) : base(comp)
//    {
//    }

//    public override string Operation()
//    {
//        return $"ConcreteDecoratorB({base.Operation()})";
//    }
//}

//public class Client
//{
//    // The client code works with all objects using the Component interface.
//    // This way it can stay independent of the concrete classes of
//    // components it works with.
//    public void ClientCode(Component component)
//    {
//        Console.WriteLine("RESULT: " + component.Operation());
//    }
//}

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Client client = new Client();

//        var simple = new ConcreteComponent();
//        Console.WriteLine("Client: I get a simple component:");
//        client.ClientCode(simple);
//        Console.WriteLine();

//        // ...as well as decorated ones.
//        //
//        // Note how decorators can wrap not only simple components but the
//        // other decorators as well.
//        ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
//        ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
//        Console.WriteLine("Client: Now I've got a decorated component:");
//        client.ClientCode(decorator2);
//    }
//}

/// <summary>
/// Code above is example from refactoring.guru, below is my own
/// </summary>

internal class Program
{
    private static void Main(string[] args)
    {
        var swimming = new SwimmingPoolEquipment(new Exercise());
        swimming.JustDoIt();
        Console.WriteLine();
        var runningAndSwimming = new RunningEquipment(new SwimmingPoolEquipment(new Exercise()));
        runningAndSwimming.JustDoIt();
        Console.WriteLine();
        var golfingAndSwimming = new SwimmingPoolEquipment(new GolfEquipment(new Exercise()));
        golfingAndSwimming.JustDoIt();
    }
}

public interface IExercise
{
    void JustDoIt();

    void AddEquipment(string equipmentName);
}

public class Exercise : IExercise
{
    public List<string> _requiredEquipment = new List<string>();

    public List<string> RequiredEquipment { get => _requiredEquipment; }

    public void AddEquipment(string equipmentName) => RequiredEquipment.Add(equipmentName);

    public void JustDoIt()
    {
        Console.WriteLine("I need to pack:");
        RequiredEquipment.ForEach(x => Console.WriteLine(x));
        Console.WriteLine("Starting exercise");
    }
}

public abstract class ExerciseEquipmentDecorator : IExercise
{
    private IExercise _exercise;

    public ExerciseEquipmentDecorator(IExercise exercise)
    {
        _exercise = exercise;
    }

    public virtual void JustDoIt() => _exercise.JustDoIt();

    public void AddEquipment(string equipmentName) => _exercise.AddEquipment(equipmentName);
}

public class RunningEquipment : ExerciseEquipmentDecorator
{
    public RunningEquipment(IExercise exercise) : base(exercise)
    {
        exercise.AddEquipment("shoes");
    }

    public override void JustDoIt()
    {
        Console.WriteLine("I'm about to run");
        base.JustDoIt();
    }
}

public class SwimmingPoolEquipment : ExerciseEquipmentDecorator
{
    public SwimmingPoolEquipment(IExercise exercise) : base(exercise)
    {
        exercise.AddEquipment("flip flops");
    }

    public override void JustDoIt()
    {
        Console.WriteLine("I'm about to swim");
        base.JustDoIt();
    }
}

public class GolfEquipment : ExerciseEquipmentDecorator
{
    public GolfEquipment(IExercise exercise) : base(exercise)
    {
        exercise.AddEquipment("golf club");
        exercise.AddEquipment("balls");
    }

    public override void JustDoIt()
    {
        Console.WriteLine("I'm about to play golf");
        base.JustDoIt();
    }
}