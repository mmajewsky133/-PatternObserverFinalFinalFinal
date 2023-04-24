using EjemploObserverFinalFinal.Hubs;
using EjemploObserverFinalFinal.Interfaces;
using System;
using System.Web.UI.WebControls;

namespace EjemploObserverFinalFinal.Implementations
{
    public class MessageEventListener : IObserver
    {
        MessageHub messageHub;

        public MessageEventListener() {
            messageHub = new MessageHub();
        }

        public void Update()
        {
            messageHub.SendEventMessage("Se realizo algo en formulario...");
        }
    }
}
