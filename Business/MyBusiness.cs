using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using signalR.Hubs;

namespace signalR.Business
{
    public class MyBusiness
    {
        readonly IHubContext<MyHub> _hubContext;

        public MyBusiness(IHubContext<MyHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task SendMessageAsync(string message)
        {
            Console.WriteLine(message);
            //ekstra işlemler.
            //clientlardaki recieve messge metodu çalışacak.
            await _hubContext.Clients.All.SendAsync("RecieveMessage", message);
        }
        

    }
}