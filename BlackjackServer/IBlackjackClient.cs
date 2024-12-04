using System.Threading.Tasks;
using JetBrains.Annotations;

namespace BlackjackServer;

public interface IBlackjackClient
{
    [UsedImplicitly]
    Task ReceiveRankRating(int rankRating);
}