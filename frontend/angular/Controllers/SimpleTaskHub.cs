using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace angular.Controllers
{
    public class SimpleTaskHub : Hub
    {
        public Task Send(string data)
        {
            return Clients.All.SendAsync("Send", data);
        }
    }
}