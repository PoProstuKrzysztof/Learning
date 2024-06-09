//var a = new A();
//var b = new B();

//b.name = "A";

//public class A
//{
//    protected string name = "A name";

//    protected int age = 15;

//    public virtual void GetInfo()
//    {
//        Console.WriteLine(name + " " + age);
//    }
//}

//internal class B : A
//{
//    public override void GetInfo()
//    {
//        this.name = "B name";
//        this.age = 10;
//        base.GetInfo();
//    }
//}

var a = new A();
var b = new B();

internal class A
{
    protected int x = 123;
}

internal class B : A
{
    private static void Main()
    {
        var a = new A();
        var b = new B();

        // Error CS1540, because x can only be accessed by
        // classes derived from A.
        // a.x = 10;

        // OK, because this class derives from A.
        b.x = 10;
    }
}