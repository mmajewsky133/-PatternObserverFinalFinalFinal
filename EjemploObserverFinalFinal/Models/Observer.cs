using EjemploObserverFinalFinal.Implementations;
using EjemploObserverFinalFinal.Interfaces;

using System.Web.UI.WebControls;

namespace EjemploObserverFinalFinal.Models
{
    public class Observer : IObserver {

        private NotificadorDeCorreo _notificadorDeCorreo;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }

        public Observer(NotificadorDeCorreo notificadorDeCorreo) {
            _notificadorDeCorreo = notificadorDeCorreo;
        }

        public void notificar(string mensaje)
        {
            //En un caso normal aqui se haria la logica para mandar para mandar un correo con los datos proporcionados, pero solo se guardara un mensaje

            //Aqui se mandara a guardar a sql la notificacion
        }

        public void suscribir()
        {
            _notificadorDeCorreo.agregarObserver(this);
        }

        public void desuscribir()
        {
            _notificadorDeCorreo.removerObserver(this);
        }
    }
}