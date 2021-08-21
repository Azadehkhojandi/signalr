using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notify.APi
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.SignalR;

    public class Hubs : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
