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
        private PageEventHandler pageEventHandler;

        private MessageEventListener messageEventListener;
        private SQLEventListener sqlEventListener;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                pageEventHandler = new PageEventHandler();

                messageEventListener = new MessageEventListener();
                sqlEventListener = new SQLEventListener();

                pageEventHandler.AgregarObserver(messageEventListener);
                pageEventHandler.AgregarObserver(sqlEventListener);
            }

        }

        protected void btnHacerEvent_Click(object sender, EventArgs e)
        {
            pageEventHandler.NotificarTodos();
        }

        protected void BtnEventListenerSuscribe_Click(object sender, EventArgs e)
        {
            pageEventHandler.RemoverObserver(messageEventListener);
            BtnEventListenerSuscribe.Text = "Activar";
        }

        protected void BtnEventListenerSQLSuscribe_Click(object sender, EventArgs e)
        {
            pageEventHandler.RemoverObserver(sqlEventListener);
            BtnEventListenerSQLSuscribe.Text = "Activar";
        }
    }
}

