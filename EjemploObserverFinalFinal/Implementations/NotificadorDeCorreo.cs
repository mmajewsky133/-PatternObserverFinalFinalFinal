using EjemploObserverFinalFinal.Interfaces;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace EjemploObserverFinalFinal.Implementations
{
    public class NotificadorDeCorreo : INotifier
    {
        private List<IObserver> _listaDeObservadores;
        
        public NotificadorDeCorreo(int id)
        {
            _listaDeObservadores = new List<IObserver>();

            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                //Agarrar usuarios relacionados con el notificador especifico 
                SqlCommand comando = new SqlCommand("SELECT o.UsuarioId FROM Observaciones o INNER JOIN Usuarios u ON o.UsuarioId = u.Id INNER JOIN Observadores ob ON o.ObservadorId = ob.Id", conexion);

                
            }
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