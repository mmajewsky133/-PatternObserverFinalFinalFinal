using EjemploObserverFinalFinal.Implementations;
using EjemploObserverFinalFinal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace EjemploObserverFinalFinal.Controllers
{
    public class SubscriptionController
    {
        CosoQueNotifica cosoQueNotifica = new CosoQueNotifica();
        Observador martin, octavio, ana, juan;


        public SubscriptionController(TextBox msgOctavio, TextBox msgMartin, TextBox msgAna, TextBox msgJuan)
        {
            octavio = new Observador(cosoQueNotifica, msgOctavio);
            martin = new Observador(cosoQueNotifica, msgMartin);
            ana = new Observador(cosoQueNotifica, msgAna);
            juan = new Observador(cosoQueNotifica, msgJuan);
        }

        public bool procesarObservers(int persona)
        {
            switch (persona)
            {
                case 1:
                    if (cosoQueNotifica._listaDeObservadores.Contains(octavio))
                    {
                        octavio.desuscribir();
                        octavio.Subscribed = false;



                        return true;
                    }
                    else
                    { 
                        octavio.suscribir();
                        octavio.Subscribed = true;



                        return false;
                    }
                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;
            }

            return true;
        }

        public void notificarObservers(String mensaje)
        {
            cosoQueNotifica.notificarTodos(mensaje);
        }
    }
}