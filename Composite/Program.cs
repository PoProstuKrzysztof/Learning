//internal abstract class Component
//{
//    public Component()
//    { }

//    // The base Component may implement some default behavior or leave it to
//    // concrete classes (by declaring the method containing the behavior as
//    // "abstract").
//    public abstract string Operation();

//    // In some cases, it would be beneficial to define the child-management
//    // operations right in the base Component class. This way, you won't
//    // need to expose any concrete component classes to the client code,
//    // even during the object tree assembly. The downside is that these
//    // methods will be empty for the leaf-level components.
//    public virtual void Add(Component component)
//    {
//        throw new NotImplementedException();
//    }

//    public virtual void Remove(Component component)
//    {
//        throw new NotImplementedException();
//    }

//    // You can provide a method that lets the client code figure out whether
//    // a component can bear children.
//    public virtual bool IsComposite()
//    {
//        return true;
//    }
//}

//// The Leaf class represents the end objects of a composition. A leaf can't
//// have any children.
////
//// Usually, it's the Leaf objects that do the actual work, whereas Composite
//// objects only delegate to their sub-components.
//internal class Leaf : Component
//{
//    public override string Operation()
//    {
//        return "Leaf";
//    }

//    public override bool IsComposite()
//    {
//        return false;
//    }
//}

//// The Composite class represents the complex components that may have
//// children. Usually, the Composite objects delegate the actual work to
//// their children and then "sum-up" the result.
//internal class Composite : Component
//{
//    protected List<Component> _children = new List<Component>();

//    public override void Add(Component component)
//    {
//        this._children.Add( component );
//    }

//    public override void Remove(Component component)
//    {
//        this._children.Remove( component );
//    }

//    // The Composite executes its primary logic in a particular way. It
//    // traverses recursively through all its children, collecting and
//    // summing their results. Since the composite's children pass these
//    // calls to their children and so forth, the whole object tree is
//    // traversed as a result.
//    public override string Operation()
//    {
//        int i = 0;
//        string result = "Branch(";

//        foreach (Component component in this._children)
//        {
//            result += component.Operation();
//            if (i != this._children.Count - 1)
//            {
//                result += "+";
//            }
//            i++;
//        }

//        return result + ")";
//    }
//}

//internal class Client
//{
//    // The client code works with all of the components via the base
//    // interface.
//    public void ClientCode(Component leaf)
//    {
//        Console.WriteLine( $"RESULT: {leaf.Operation()}\n" );
//    }

//    // Thanks to the fact that the child-management operations are declared
//    // in the base Component class, the client code can work with any
//    // component, simple or complex, without depending on their concrete
//    // classes.
//    public void ClientCode2(Component component1, Component component2)
//    {
//        if (component1.IsComposite())
//        {
//            component1.Add( component2 );
//        }

//        Console.WriteLine( $"RESULT: {component1.Operation()}" );
//    }
//}

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Client client = new Client();

//        // This way the client code can support the simple leaf
//        // components...
//        Leaf leaf = new Leaf();
//        Console.WriteLine( "Client: I get a simple component:" );
//        client.ClientCode( leaf );

//        // ...as well as the complex composites.
//        Composite tree = new Composite();
//        Composite branch1 = new Composite();
//        branch1.Add( new Leaf() );
//        branch1.Add( new Leaf() );
//        Composite branch2 = new Composite();
//        branch2.Add( new Leaf() );
//        tree.Add( branch1 );
//        tree.Add( branch2 );
//        Console.WriteLine( "Client: Now I've got a composite tree:" );
//        client.ClientCode( tree );

//        Console.Write( "Client: I don't need to check the components classes even when managing the tree:\n" );
//        client.ClientCode2( tree, leaf );
//    }
//}

/// <summary>
/// Code above is example from refactoring.guru, below is my own
/// </summary>
///

public interface IComposite
{
    void AddElement(IComposite element);

    void DeleteElement(IComposite element);

    void Render();
}

public class Leaf : IComposite
{
    public string Name { get; set; }

    public void Render()
    {
        Console.WriteLine(Name + " rendering..");
    }

    public void AddElement(IComposite element)
    {
    }

    public void DeleteElement(IComposite element)
    {
    }

    public Leaf(string name)
    {
        Name = name;
    }
}

public class Node : IComposite
{
    private List<IComposite> Lista = new List<IComposite>();

    public string Name { get; set; }

    public void Render()
    {
        Console.WriteLine(Name + " start of rendering");
        foreach (IComposite k in Lista)
        {
            k.Render();
        }
        Console.WriteLine(Name + " end of rendering");
    }

    public void AddElement(IComposite element)
    {
        Lista.Add(element);
    }

    public void DeleteElement(IComposite element)
    {
        Lista.Remove(element);
    }

    public Node(string name)
    {
        Name = name;
    }
}

internal class MainClass
{
    public static void Main(string[] args)
    {
        Node korzen = new Node("Korzeń");
        korzen.AddElement(new Leaf("Liść 1.1"));

        Node Node2 = new Node("Węzeł 2");
        korzen.AddElement(Node2);
        Node2.AddElement(new Leaf("Liść 2.1"));
        Node2.AddElement(new Leaf("Liść 2.2"));
        Node2.AddElement(new Leaf("Liść 2.3"));

        Node Node3 = new Node("Węzeł 3");
        korzen.AddElement(Node3);
        Node3.AddElement(new Leaf("Liść 3.1"));
        Node3.AddElement(new Leaf("Liść 3.2"));

        Node Node33 = new Node("Węzeł 3.3");
        Node3.AddElement(Node33);
        Node33.AddElement(new Leaf("Liść 3.3.1"));

        korzen.Render();
    }
}