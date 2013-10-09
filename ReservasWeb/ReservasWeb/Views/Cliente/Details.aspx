<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Cliente>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Detalle del Cliente
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <fieldset>
            <legend>Detalle del Cliente</legend>
            <table border="0;">
                <tr>
                    <td>
                        <div class="display-label">
                            DNI:</div>
                    </td>
                    <td>
                        <div class="display-field">
                            <%: Model.dnicliente %></div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="display-label">
                            Nombre del Cliente:</div>
                    </td>
                    <td>
                        <div class="display-field">
                            <%: Model.nombrecliente %></div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="display-label">
                            Apellido Paterno:</div>
                    </td>
                    <td>
                        <div class="display-field">
                            <%: Model.apellidopaterno %></div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="display-label">
                            Apellido Materno:</div>
                    </td>
                    <td>
                        <div class="display-field">
                            <%: Model.apellidomaterno %></div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="display-label">
                            Dirección del Cliente:</div>
                    </td>
                    <td>
                        <div class="display-field">
                            <%: Model.direccioncliente %></div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="display-label">
                            Teléfono:</div>
                    </td>
                    <td>
                        <div class="display-field">
                            <%: Model.telefono %></div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="display-label">
                            Celular:</div>
                    </td>
                    <td>
                        <div class="display-field">
                            <%: Model.celular %></div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="display-label">
                            Correo:</div>
                    </td>
                    <td>
                        <div class="display-field">
                            <%: Model.correo %></div>
                    </td>
                </tr>
            </table>
        </fieldset>
        <p>
        </p>
        <p>
            <button type="submit" class="btn btn-success">
                <%: Html.ActionLink("Editar", "Edit", new { id = Model.codigocliente })%></button>
            <button type="submit" class="btn btn-success">
                <%: Html.ActionLink("Regresar a la lista de Clientes", "Index", new { @style = "color:white" })%></button>
        </p>
    </div>
</asp:Content>
