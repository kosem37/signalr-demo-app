using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace hubProxy
{
    public class MainHub : Hub
    {
        public Task NotifyAll(object message)
        {
            return Client.All.SendAsync("NotifyAll", message);
        }
    }
}
