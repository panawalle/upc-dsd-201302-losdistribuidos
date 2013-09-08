<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Cliente>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Datos del Cliente</legend>
        
        <div class="display-label">DNI</div>
        <div class="display-field"><%: Model.dnicliente %></div>
        
        <div class="display-label">NOMBRE</div>
        <div class="display-field"><%: Model.nombrecliente %></div>
        
        <div class="display-label">APELLIDOS</div>
        <div class="display-field"><%: Model.apellidocliente %></div>
        
        <div class="display-label">CORREO</div>
        <div class="display-field"><%: Model.correocliente %></div>
        
        <div class="display-label">SEXO</div>
        <div class="display-field"><%: Model.sexocliente %></div>
        
        <div class="display-label">FECHA DE NACIMIENTO</div>
        <div class="display-field"><%: Model.fecnacliente %></div>
        
        <div class="display-label">DISTRITO</div>
        <div class="display-field"><%: Model.distritocliente %></div>
        
        <div class="display-label">PROVINCIA</div>
        <div class="display-field"><%: Model.provinciacliente %></div>
        
        <div class="display-label">DEPARTAMENTO</div>
        <div class="display-field"><%: Model.departamentocliente %></div>
        
        <div class="display-label">ValidateRequest</div>
        <div class="display-field"><%: Model.ValidateRequest %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Edit", "Edit", new { /* id=Model.PrimaryKey */ }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

