<%@ Page Title="Pagina Principal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EjemploObserverFinalFinal._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="text-center">
        <h1 class="display-4">Ejemplo de Patron Observer</h1>
    </div>
    <div id="bodyMandarMensaje">
        <h2>Event doer</h2>
        <asp:Button ID="btnHacerEvent" CssClass="btn btn-primary" runat="server" Text="Enviar mensaje" Width="280px" OnClick="btnHacerEvent_Click" />
    </div>
    <hr />
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <h3>Event Listener</h3>
                <asp:Button ID="BtnEventListenerSuscribe" CssClass="btn btn-primary" runat="server" Text="Desactivar" Width="800px" OnClick="BtnEventListenerSuscribe_Click" />
            </div>
            <div class="col-md-6">
                <h3>Event Listener (SQL)</h3>
                <asp:Button ID="BtnEventListenerSQLSuscribe" CssClass="btn btn-primary" runat="server" Text="Desactivar" Width="800px" OnClick="BtnEventListenerSQLSuscribe_Click" />                
            </div>
        </div>
    </div>
</asp:Content>
