using EjemploObserverFinalFinal.Implementations;
using EjemploObserverFinalFinal.Interfaces;
using ObsrPatro.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EjemploObserverFinalFinal.Interfaces;

namespace EjemploObserverFinalFinal
{
    public partial class _Default : System.Web.UI.Page
    {

        CosoQueNotifica cosoQueNotifica = new CosoQueNotifica();
 
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                
            }
        }

        protected void btnMandarMensaje_Click(object sender, EventArgs e)
        {
            string mensaje = tbMensaje.Text;

            Observador martin = new Observador(cosoQueNotifica, msgMartin);
            Observador octavio = new Observador(cosoQueNotifica, msgOctavio);
            Observador ana = new Observador(cosoQueNotifica, msgAna);
            Observador juan = new Observador(cosoQueNotifica, msgJuan);



            martin.suscribir();
            octavio.suscribir();
            ana.suscribir();
            juan.suscribir();


            if (cosoQueNotifica != null)
            {
                cosoQueNotifica.notificarTodos(mensaje);
            }
        }

        
    }
}

