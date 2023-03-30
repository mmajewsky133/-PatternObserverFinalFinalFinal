using EjemploObserverFinalFinal.Interfaces;
using System.Collections.Generic;

using EjemploObserverFinalFinal.Interfaces;
using System.Collections.Generic;

namespace EjemploObserverFinalFinal.Implementations
{
    public class CosoQueNotifica : INotifier
    {

        private List<IObserver> _listaDeObservadores;
        

        public CosoQueNotifica()
        {
            _listaDeObservadores = new List<IObserver>();
            
        }

        public void agregarObserver(IObserver observador)
        {
            _listaDeObservadores.Add(observador);
        }

        public void removerObserver(IObserver observador)
        {
            _listaDeObservadores.Remove(observador);
        }

        public void notificarTodos(string mensaje)
        {
            foreach (var observador in _listaDeObservadores)
            {
                observador.notificar(mensaje);
                }


        }
    }
}

