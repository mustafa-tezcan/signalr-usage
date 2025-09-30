using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace signalR.Interfaces
{
    public interface IMessageClient
    {
        Task Clients(List<string> clients);
        Task UserJoined(string ConnectionId);
        Task UserLaved(string ConnectionId);
        Task RecieveMessage(string message);
    }
}