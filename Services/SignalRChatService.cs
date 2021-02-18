using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.SignalR.Client;

namespace NWS_Projekt.Services
{
    public class SignalRChatService
    {
        private readonly HubConnection _connection;

        public event Action<String> MessageReceived;

        public SignalRChatService(HubConnection connection)
        {
            _connection = connection;

            _connection.On<String>("ReceiveMessage", (message) => MessageReceived?.Invoke(message));
        }

        public async Task Connect()
        {
            await _connection.StartAsync();
        }

        public async Task SendMessage(string message)
        {
            await _connection.SendAsync("SendMessage", message);
        }
    }
}
