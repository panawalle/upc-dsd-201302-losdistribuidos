<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Cliente>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Detalle del Cliente
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>DETALLE DEL CLIENTE</h2>

    <fieldset>
        <legend>Datos del Cliente</legend>
        
<%--        <div class="display-label">codigocliente</div>
        <div class="display-field"><%: Model.codigocliente %></div>
        --%>
        <div class="display-label">DNI</div>
        <div class="display-field"><%: Model.dnicliente %></div>
        
<%--        <div class="display-label">tipo</div>
        <div class="display-field"><%: Model.tipo %></div>
        --%>
        <div class="display-label">Nombre del Cliente</div>
        <div class="display-field"><%: Model.nombrecliente %></div>
        
        <div class="display-label">Apellido Paterno</div>
        <div class="display-field"><%: Model.apellidopaterno %></div>
        
        <div class="display-label">Apellido Materno</div>
        <div class="display-field"><%: Model.apellidomaterno %></div>
        
        <div class="display-label">Dirección del Cliente</div>
        <div class="display-field"><%: Model.direccioncliente %></div>
        
        <div class="display-label">Teléfono</div>
        <div class="display-field"><%: Model.telefono %></div>
        
        <div class="display-label">Celular</div>
        <div class="display-field"><%: Model.celular %></div>
        
        <div class="display-label">Correo</div>
        <div class="display-field"><%: Model.correo %></div>
        
       <%-- <div class="display-label">ValidateRequest</div>
        <div class="display-field"><%: Model.ValidateRequest %></div>
        --%>
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar", "Edit", new { id = Model.codigocliente })%> |
        <%: Html.ActionLink("Regresar a la lista de Clientes", "Index") %>
    </p>

</asp:Content>

