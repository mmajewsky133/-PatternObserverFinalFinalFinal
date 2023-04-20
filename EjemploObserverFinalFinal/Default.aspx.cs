using EjemploObserverFinalFinal.Controllers;
using EjemploObserverFinalFinal.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemploObserverFinalFinal
{
    public partial class _Default : System.Web.UI.Page
    {

        SubscriptionController controller;

        protected void Page_Load(object sender, EventArgs e)
        {
            controller = new SubscriptionController(msgOctavio, msgMartin, msgAna, msgJuan);

            controller.procesarObservers(1);
        
        }

        protected void btnSubs1_Click(object sender, EventArgs e)
        {
            controller.procesarObservers(1);

            btnSubs1.Text = "Desuscribir";
            
            //if (controller.procesarObservers(1))
            //{
            //    btnSubs1.Text = "Suscribir";
            //}
            //else
            //{
            //    btnSubs1.Text = "Desuscribir";
            //}
        }

        protected void btnSubs2_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnSubs3_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnSubs4_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnMandarMensaje_Click(object sender, EventArgs e)
        {
            string mensaje = tbMensaje.Text;

            if (controller != null)
            {
                controller.notificarObservers(mensaje);
            }
        }

        
    }
}

