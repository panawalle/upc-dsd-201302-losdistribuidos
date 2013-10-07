<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Cliente>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Eliminar Cliente
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <fieldset>
            <legend>Eliminar Cliente</legend>
            <div class="display-label">
                Dni</div>
            <div class="display-field">
                <%: Model.dnicliente %></div>
            <div class="display-label">
                Nombre Completo</div>
            <div class="display-field">
                <%: Model.nombrecliente %></div>
            <div class="display-label">
                Apellido Paterno</div>
            <div class="display-field">
                <%: Model.apellidopaterno %></div>
            <div class="display-label">
                Apellido Materno</div>
            <div class="display-field">
                <%: Model.apellidomaterno %></div>
            <div class="display-label">
                Dirección del Cliente</div>
            <div class="display-field">
                <%: Model.direccioncliente %></div>
            <div class="display-label">
                Teléfono</div>
            <div class="display-field">
                <%: Model.telefono %></div>
            <div class="display-label">
                Celular</div>
            <div class="display-field">
                <%: Model.celular %></div>
            <div class="display-label">
                Correo</div>
            <div class="display-field">
                <%: Model.correo %></div>
            <% using (Html.BeginForm())
               { %>
            <p>
            </p>
            <p>
                <input type="submit" class="btn btn-success" value="Eliminar" />
                <button type="submit" class="btn btn-success">
                    <%: Html.ActionLink("Regresar a la lista de Clientes", "Index", new { @style = "color:red" })%></button>
            </p>
        </fieldset>
        <% } %>
    </div>
</asp:Content>
