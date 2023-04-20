﻿using EjemploObserverFinalFinal.Interfaces;
using System;
using System.Web.UI.WebControls;

namespace EjemploObserverFinalFinal.Implementations
{
    public class Observador : IObserver
    {
        private CosoQueNotifica _cosoQueNotifica;
        private TextBox _mensajeTextBox;

        public bool Subscribed {get; set;}

        public Observador(CosoQueNotifica cosoQueNotifica, TextBox mensajeTextBox)
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
