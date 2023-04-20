<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EjemploObserverFinalFinal._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="text-center">
        <h1 class="display-4">Ejemplo de Patron Observer</h1>
    </div>
    <div id="bodyMandarMensaje">
        <h2>Notificador</h2>
        <asp:TextBox ID="tbMensaje" CssClass="form-control my" runat="server" Width="280px" ToolTip="Escriba el mensaje a mandar subscriptores aqui..."></asp:TextBox>
        <br />
        <asp:Button ID="btnMandarMensaje" CssClass="btn btn-primary" runat="server" Text="Enviar mensaje" Width="280px" OnClick="btnMandarMensaje_Click" />
    </div>
    <hr />
    <div id="observadores">
        <h2>Observadores</h2>
        <div id="observador1">
            <p>Nombre: Octavio</p>
            <p>Mensaje:</p>
            <asp:TextBox ID="msgOctavio" CssClass="form-control my" runat="server" Width="280px" placeholder="Las notificaciones llegaran aquí..." ToolTip="Las notificaciones llegaran aquí..." ReadOnly="True" />
            <br />
            <asp:Button ID="btnSubs1" CssClass="btn btn-primary" runat="server" Text="Suscribir" Width="280px" OnClick="btnSubs1_Click" />
        </div>
        <hr>
        <div id="observador2">
            <p>Nombre: Martin</p>
            <p>Mensaje:</p>
            <asp:TextBox ID="msgMartin" CssClass="form-control my" runat="server" Width="280px" placeholder="Las notificaciones llegaran aquí..." ToolTip="Las notificaciones llegaran aquí..." ReadOnly="True" />
            <br />
            <asp:Button ID="btnSubs2" CssClass="btn btn-primary" runat="server" Text="Suscribir" Width="280px" OnClick="btnSubs2_Click" />
        </div>
        <hr>
        <div id="observador3">
            <p>Nombre: Ana</p>
            <p>Mensaje:</p>
            <asp:TextBox ID="msgAna" CssClass="form-control my" runat="server" Width="280px" placeholder="Las notificaciones llegaran aquí..." ToolTip="Las notificaciones llegaran aquí..." ReadOnly="True" />
            <br />
            <asp:Button ID="btnSubs3" CssClass="btn btn-primary" runat="server" Text="Suscribir" Width="280px" OnClick="btnSubs3_Click" />
        </div>
        <hr>
        <div id="observador4">
            <p>Nombre: Juan</p>
            <p>Mensaje:</p>
            <asp:TextBox ID="msgJuan" CssClass="form-control my" runat="server" Width="280px" placeholder="Las notificaciones llegaran aquí..." ToolTip="Las notificaciones llegaran aquí..." ReadOnly="True" />
            <br />
            <asp:Button ID="btnSubs4" CssClass="btn btn-primary" runat="server" Text="Suscribir" Width="280px" OnClick="btnSubs4_Click" />
        </div>
        <hr>
    </div>
</asp:Content>
