<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EjemploObserverFinalFinal._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="text-center">
        <h1 class="display-4">Ejemplo de Patron Observer</h1>
    </div>
    <div id="bodyMandarMensaje">
        <h2>Notificador</h2>
        <asp:TextBox ID="tbMensaje" CssClass="form-control my" runat="server" ToolTip="Escriba el mensaje a mandar subscriptores aqui..."></asp:TextBox>
        <asp:Button ID="btnMandarMensaje" CssClass="btn btn-primary" runat="server" Text="Enviar mensaje" Width="280px" OnClick="btnMandarMensaje_Click" />
    </div>
    <hr />
    <div id="observadores">
        <h2>Observadores</h2>
        <div id="observador1">
            <p>Nombre: Octavio</p>
            <p>Mensaje:</p>
            <asp:TextBox ID="msgOctavio" CssClass="form-control my" runat="server"  placeholder="Las notificacion llegaran aqui..." ToolTip="Las notificacion llegaran aqui..." ReadOnly="True"/>
        </div>
        <hr>
        <div id="observador2">
            <p>Nombre: Martin</p>
            <p>Mensaje:</p>
            <asp:TextBox ID="msgMartin" CssClass="form-control my" runat="server" placeholder="Las notificacion llegaran aqui..." ToolTip="Las notificacion llegaran aqui..." ReadOnly="True"/>
        </div>
    </div>
</asp:Content>

