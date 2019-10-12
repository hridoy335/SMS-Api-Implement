<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MessageSend.aspx.cs" Inherits="APITesting.MessageSend" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
</p>
    <p>
        <asp:Button ID="ButtonSMS" runat="server" OnClick="ButtonSMS_Click" Text="Send sms" />
</p>
</asp:Content>
