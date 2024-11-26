﻿using Microsoft.AspNetCore.SignalR;

namespace BlackjackServer;

public class OnlinePlayHub : Hub<IBlackjackClient>
{
    public async Task SendMessage(string message) => await Clients.Caller.ReceiveMessage(message);
}