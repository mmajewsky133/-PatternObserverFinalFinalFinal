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

            Martin martin = new Martin(cosoQueNotifica, msgMartin);
            Octavio octavio = new Octavio(cosoQueNotifica, msgOctavio);

            martin.suscribir();
            octavio.suscribir();
            

            if (cosoQueNotifica != null)
            {
                cosoQueNotifica.notificarTodos(mensaje);
            }
        }

        
    }
}

