A A = new A();
B B = new B();
A C = new C();
A.Print();
B.Print();
C.Print();

public class A
{
    public virtual void Print()
    {
        Console.WriteLine("Print method of class A.");
    }
}

public class B : A
{
    public void Print()
    {
        Console.WriteLine("Print method of class B");
    }
}

public class C : A
{
    public void Print()
    {
        Console.WriteLine("Print method of class C");
    }
}