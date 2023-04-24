<%@ Page Title="Event Listener (SQL)" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="EjemploObserverFinalFinal.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Event Listener (SQL)</h3>
    <asp:GridView ID="gvEvents" runat="server" AutoGenerateColumns="False" Width="400px" >
        <Columns>
            <asp:BoundField DataField="LogDate" HeaderText="Fecha" />
            <asp:BoundField DataField="Detail" HeaderText="Detalles" />
        </Columns>
    </asp:GridView>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/jquery.signalR-2.4.3.min.js"></script>
    <script src="signalr/hubs"></script>
    <script type="text/javascript">
        $(function() {
            var hub = $.connection.messageHub;
            hub.client.broadcastMessage = function (date, detail) {
                location.reload();
            };
            $.connection.hub.start().done();
        });
    </script>
</asp:Content>
