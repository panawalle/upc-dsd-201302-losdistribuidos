<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    ConfirmacionRegistro
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Los datos del cliente fueron registrados correctamente.</h2>
    <h3 style="color: Green">
     <%--   <%= TempData["mensaje"] %></h3>--%>
</asp:Content>
