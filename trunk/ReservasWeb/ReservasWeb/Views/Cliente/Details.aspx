<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Cliente>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Detalle del Cliente
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>DETALLE DEL CLIENTE</h2>

    <fieldset>
        <legend>Datos del Cliente</legend>
        
        <div class="display-label">Dni</div>
        <div class="display-field"><%: Model.dnicliente %></div>
        
        <div class="display-label">Nombre</div>
        <div class="display-field"><%: Model.nombrecliente %></div>
        
        <div class="display-label">Apellidos</div>
        <div class="display-field"><%: Model.apellidocliente %></div>
        
        <div class="display-label">Correo</div>
        <div class="display-field"><%: Model.correocliente %></div>
        
        <div class="display-label">Sexo</div>
        <div class="display-field"><%: Model.sexocliente %></div>
        
        <div class="display-label">Fecha de Nacimiento</div>
        <div class="display-field"><%: Model.fecnacliente %></div>
        
        <div class="display-label">Distrito</div>
        <div class="display-field"><%: Model.distritocliente.nombredistrito%></div>
        
        <div class="display-label">Provincia</div>
        <div class="display-field"><%: Model.provinciacliente.nombreprovincia %></div>
        
        <div class="display-label">Departamento</div>
        <div class="display-field"><%: Model.departamentocliente.nombredepartamento %></div>
        
        <div class="display-label">ValidateRequest</div>
        <div class="display-field"><%: Model.ValidateRequest %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar Cliente", "Edit", new { /* id=Model.PrimaryKey */ }) %> |
        <%: Html.ActionLink("Regresar al listado", "Index") %>
    </p>

</asp:Content>

