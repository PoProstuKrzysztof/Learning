//int x = 1;

//do
//{
//    x++;
//} while (x < 25);

//Console.WriteLine("x " + x);

//int i = 5;
//Calculate(ref i);
//Console.WriteLine(i);

////string message = "bet";
////MessageSender messageSender = new MessageSender();
////MessageDelegate myDelegate = new MessageDelegate(WriteMessage);

//// Poprawne użycie delegatu
////messageSender.SendMessage(message, myDelegate);

//Console.ReadLine();
//TransactionHandler tH = new();

//static void WriteMessage(string mess)
//{
//    Console.WriteLine(mess);
//}

//static void Calculate(ref int x)
//{
//    x = 15;
//}

//internal delegate void MessageDelegate(string message);

//internal delegate void MyDelegate(int transactionX, int transactionY);

//public class TransactionHandler
//{
//    private event MessageDelegate transactions;

//    public IList<int> _transactions = new List<int>();

//    public TransactionHandler()
//    {
//    }

//    public int MakeTransaction(int x, int y)
//    {
//        int z = x + y;
//        return z;
//    }
//}

//internal class MessageSender
//{
//    public void SendMessage(string message, MessageDelegate callback)
//    {
//        // Wywołanie delegatu z przekazaniem wiadomości
//        callback("Super " + message);
//    }
//}

Func<int, int, int> multiply = (x, y) => x * y;

Func<bool, string> isTrue = (isTrue) => "it's true";

multiply(10, 10);
MyDelegate<string> message = Add100;
static string Add100(string b) => b + "Happens";

static int Add200(int s) => s + 200;

public delegate T MyDelegate<T>(T x);

public delegate TResult Func<in T, out TResult>(T arg);

public class A
{
    public Action MyProperty { get; set; }
}