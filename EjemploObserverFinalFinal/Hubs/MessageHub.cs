using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploObserverFinalFinal.Hubs
{
    public class MessageHub : Hub
    { 
        public void SendEventMessage(String detail)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<MessageHub>();

            context.Clients.All.broadcastMessage(detail, DateTime.Now.ToString());
        }
    }
}