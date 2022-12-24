using Azure.Identity;
using LANMessenger.Shared.Models;
using Microsoft.AspNetCore.SignalR;

namespace LANMessenger.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(UserDTO user, MessageDTO message)
        {
            UserMessageDTO userMessage = new UserMessageDTO
            {
                SenderUsername = user.username,
                message = message.message,
                Date = message.Date,
                sender_ip= Context.GetHttpContext().Connection.RemoteIpAddress.ToString(),
                sender_device= message.sender_device
            };
            await Clients.All.SendAsync("ReceiveMessage", userMessage);
        }
    }
}
