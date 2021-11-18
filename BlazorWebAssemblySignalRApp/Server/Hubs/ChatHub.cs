using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorWebAssemblySignalRApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            if(user == null ){
                user = "Anonymous";
            }
            if(message == null){
                message = "Anonymous";
            }
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}