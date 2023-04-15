internal delegate void MessageDelegate(string message);

internal class MessageSender
{
    public void SendMessage(string message, MessageDelegate callback)
    {
        callback( "Super" + message );
    }
}