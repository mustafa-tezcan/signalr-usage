using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace signalR.Hubs
{
    public class MessageHub : Hub
    {
        // public async Task SendMessageAsync(string message, IEnumerable<string> connectionIds)
        // {

        public async Task SendMessageAsync(string message, string groupName)
        {

            #region Caller 
            //sadece servera bildirim gönderen clienta msaj gönderir .
            #endregion

            #region all 
            //sadece servera bildirim gönderen clienta msaj gönderir .
            #endregion

            #region Caller 
            //sadece servera bildirim gönderen clienta msaj gönderir .
            #endregion

            #region HubClients metodlari 
            // AllExcept -> belirtilen clientlar hariç tüm clientlara mesaj gönderir.
            // Client-> belitilen clienta mesaj gönderir.mesela bir kişiden sadece belirtilen id ye mesaj atabilirm.
            // Clients -> belirtilen clientlara mesaj gönderir.
            // Group -> gruba dahil olan clientlara mesaj gönderilir.
            // GroupExcept -> belirtilen clientlar hariç gruba dahil olan clientlara mesaj gönderilir.
            // Groups -> birden fazla gruptaki clientlara bildiride bulunmamızı sağlar.
            // User
            // Users
            // OthersInGroup -> bildiride bulunan client harici gruptaki diğer elemanlara mesaj gönderilir.
            #endregion
            await Clients.Group(groupName).SendAsync("recieveMessage", message);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.Caller.SendAsync("getConnectionId", Context.ConnectionId);
        }

        public async Task AddGroup(string connectionId, string groupName)
        {
            await Groups.AddToGroupAsync(connectionId, groupName);
        }
        
    }
}