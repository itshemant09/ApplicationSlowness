﻿<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Slowness detected</h3>
    <p>Page loaded after 
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;Miliseconds.</p>
</asp:Content>
