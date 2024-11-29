using Microsoft.AspNetCore.SignalR;

namespace BlackjackServer;

public class OnlinePlayHub : Hub<IBlackjackClient>
{
    public void SubmitScore(RankChangeOutcome outcome, int cardCount)
    {
        ScoreProcessor.Process(outcome, cardCount, Context.ConnectionId);
    }
}