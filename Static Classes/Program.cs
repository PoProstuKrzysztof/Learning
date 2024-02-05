// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Inventory next = new Inventory(1);

internal class Inventory(int Shovel)
{
    public static int Shovel { get; set; }
}