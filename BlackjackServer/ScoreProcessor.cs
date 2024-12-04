using System;

namespace BlackjackServer;

public static class ScoreProcessor
{
    public static void Process(RankChangeOutcome outcome, int cardCount, string connectionId)
    {
        Console.WriteLine($"user {connectionId} " + (outcome == RankChangeOutcome.Gain ? "should" : "shouldn't") + $" gain rank with {cardCount} cards");
    }
}