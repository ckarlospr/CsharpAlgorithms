using Microsoft.AspNetCore.SignalR;

namespace ChatRoom
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(String room, string user, string message)
        {
            await Clients.Group(room).SendAsync("ReceiveMessage", user, message);
        }

        public async Task AddToGroup(String room)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, room);
            await Clients.Group(room).SendAsync("ShowWho", 
                $"Somewhere have been connected {Context.ConnectionId}");
        }
    }
}
