<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyWhoisApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Label runat="server" ID="lblipaddress" Text="Enter Domain:" AssociatedControlID="txtaddress"></asp:Label>
        <asp:TextBox runat="server" ID="txtaddress"></asp:TextBox>
        <br />
        <%-- <asp:Label runat="server" ID="intruction" Text="OR"></asp:Label>
        <br />
         <asp:Label runat="server" ID="lbldomain" Text="Enter Domain:" AssociatedControlID="txtdomain"></asp:Label>
        <asp:TextBox runat="server" ID="txtdomain"></asp:TextBox>--%>
        <br />
        <asp:Button runat="server" ID="btnsearch" Text="Search" OnClick="btnsearch_Click" />
        <br />
        <asp:Panel runat="server" Visible="false" ID="panelresult">
             <br /> <br />
            <asp:TextBox runat="server" ID="txtresults" TextMode="MultiLine" Width="800px" Height="600px" ReadOnly="true"></asp:TextBox>
            <br />
            <%--<asp:Label runat="server" ID="lblresults"></asp:Label>--%>
        </asp:Panel>
    </div>

    

</asp:Content>
