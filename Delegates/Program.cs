int x = 1;

do
{
    x++;
} while (x < 25);

Console.WriteLine( "x " + x );

internal delegate void MessageDelegate(string message);

internal class MessageSender
{
    public void SendMessage(string message, MessageDelegate callback)
    {
        callback( "Super" + message );
    }
}