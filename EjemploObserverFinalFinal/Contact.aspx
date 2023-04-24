<%@ Page Title="Event Listener" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="EjemploObserverFinalFinal.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <br />
    <ul id="log"></ul>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/jquery.signalR-2.4.3.min.js"></script>
    <script src="signalr/hubs"></script>
    <script type="text/javascript">
        $(function() {
            var hub = $.connection.messageHub;
            hub.client.broadcastMessage = function (date, detail) {
               // Html encode display name and message. 
                var encodedDate = $('<div />').text(date).html();
                var encodedDetail = $('<div />').text(detail).html();
               // Add the message to the page. 
                $('#log').append('<li><strong>' + encodedDate
                    + '</strong>:&nbsp;&nbsp;' + encodedDetail + '</li>');
            };
            $.connection.hub.start().done();
        });
    </script>
</asp:Content>