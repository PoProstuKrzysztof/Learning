IndexedClass<string> testArr = new();

testArr[0] = "s";

internal class IndexedClass<T>
{
    public T[] arr = new T[100];

    public T this[int i]
    {
        get => arr[i];
        set => arr[i] = value;
    }
}