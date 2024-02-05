internal class Sample
{
    public int index;
    public int[] arr = new int[10];

    public void fun(int i, int val)
    {
        arr[i] = val;
    }
}

internal class MyProgram
{
    private static void Main(string[] args)
    {
        Sample s = new Sample();
        s.index = 20;
        //Sample.fun(1, 5);
        s.fun(1, 5);
    }
}