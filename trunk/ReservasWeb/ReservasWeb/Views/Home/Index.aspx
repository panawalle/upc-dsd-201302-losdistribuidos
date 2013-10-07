<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%--<h2><%: ViewData["Message"] %></h2>--%>
    
    <div class="jumbotron">
        <div class="container">
            <h1>
                Bienvenidos!!</h1>
            <p>
                Una forma fácil, cómoda, rápida y segura de agendar su hora de atención en cualquier
                punto de la red de servicio técnico autorizado a lo largo de todo Perú. A través
                de este sistema usted tendrá la flexibilidad de escoger el día, la hora y el lugar
                para llevar su automóvil de acuerdo a su propia necesidad.</p>
            <p>
                <a class="btn btn-primary btn-lg">Leer más &raquo;</a></p>
        </div>
    </div>
</asp:Content>
