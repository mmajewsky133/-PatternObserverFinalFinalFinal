using EjemploObserverFinalFinal.Interfaces;
using System.Collections.Generic;

namespace EjemploObserverFinalFinal.Implementations
{
    public class PageEventHandler
    {
        private List<IObserver> _EventListenersList;
        
        public PageEventHandler()
        {
            _EventListenersList = new List<IObserver>();
        }

        public void AgregarObserver(IObserver EventListener)
        {
            _EventListenersList.Add(EventListener);
        }

        public void RemoverObserver(IObserver EventListener)
        {
            _EventListenersList.Remove(EventListener);
        }

        public void NotificarTodos()
        {
            foreach (var eventListener in _EventListenersList)
            {
                eventListener.Update();
            }
        }
    }
}

