
using Hiver.WebApp.Models;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Hiver.WebApp.Infrastructure
{
    public class signalrServer : Hub
    {
        public async Task SendMessage(NotifyMessage message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
