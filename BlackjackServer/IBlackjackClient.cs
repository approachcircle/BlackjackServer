namespace BlackjackServer;

public interface IBlackjackClient
{
    Task ReceiveMessage(string message);
}