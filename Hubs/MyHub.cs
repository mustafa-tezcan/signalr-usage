using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using signalR.Interfaces;

namespace signalR.Hubs
{
    public class MyHub : Hub<IMessageClient>
    {
        //client bağlantılarını tutucam , bağladığında eklicem , koptuğunda silicem. 
        static List<string> clients = new List<string>();





        public async Task SendMessageAsync(string message)
        {
            Console.WriteLine(message);

            //ekstra işlemler.
            //clientlardaki recieve messge metodu çalışacak.
            await Clients.All.RecieveMessage(message);
        }

        public override async Task OnConnectedAsync()
        {
            Console.WriteLine("yeni bir client bağlandi.");
            clients.Add(Context.ConnectionId);
            // await Clients.All.SendAsync("clients", clients);
            // await Clients.All.SendAsync("userJoined", Context.ConnectionId);
            await Clients.All.Clients(clients);
            await Clients.All.UserJoined(Context.ConnectionId);


        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            Console.WriteLine("bağlanti koptu");
            clients.Remove(Context.ConnectionId);
            // await Clients.All.SendAsync("clients", clients);
            // await Clients.All.SendAsync("userLeaved", Context.ConnectionId);

            await Clients.All.Clients(clients);
            await Clients.All.UserLaved(Context.ConnectionId);
        }
    }
}