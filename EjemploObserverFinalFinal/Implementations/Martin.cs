using EjemploObserverFinalFinal.Implementations;
using EjemploObserverFinalFinal.Interfaces;
using System;
using System.Web.UI.WebControls;

namespace ObsrPatro.Implementations
{
    public class Martin : IObserver
    {
        private CosoQueNotifica _cosoQueNotifica;
        private TextBox _mensajeTextBox;
        private CosoQueNotifica cosoQueNotifica;

        public Martin(CosoQueNotifica cosoQueNotifica, TextBox mensajeTextBox)
        {
            _cosoQueNotifica = cosoQueNotifica;
            _mensajeTextBox = mensajeTextBox;
        }

        public void notificar(string mensaje)
        {
            _mensajeTextBox.Text = mensaje;
        }

        public void suscribir()
        {
            _cosoQueNotifica.agregarObserver(this);
        }

        public void desuscribir()
        {
            _cosoQueNotifica.removerObserver(this);
        }
    }
}

