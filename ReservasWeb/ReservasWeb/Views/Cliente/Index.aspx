<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<ReservasWeb.Models.Cliente>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <fieldset>
            <legend>Consultar Cliente</legend>
            <table class="table table-hover">
                <tr>
                    <th>
                        Código
                    </th>
                    <th>
                        Dni
                    </th>
                    <th>
                        Nombres
                    </th>
                    <th>
                        Apellido - Paterno
                    </th>
                    <th>
                        Apellido - Materno
                    </th>
                    <th>
                        Dirección
                    </th>
                    <th>
                        Teléfono
                    </th>
                    <th>
                        Celular
                    </th>
                    <th>
                        Correo
                    </th>
                    <th>
                        Opciones
                    </th>
                </tr>
                <% foreach (var item in Model)
                   { %>
                <tr>
                    <td>
                        <%: item.codigocliente %>
                    </td>
                    <td>
                        <%: item.dnicliente %>
                    </td>
                    <td>
                        <%: item.nombrecliente %>
                    </td>
                    <td>
                        <%: item.apellidopaterno %>
                    </td>
                    <td>
                        <%: item.apellidomaterno %>
                    </td>
                    <td>
                        <%: item.direccioncliente %>
                    </td>
                    <td>
                        <%: item.telefono %>
                    </td>
                    <td>
                        <%: item.celular %>
                    </td>
                    <td>
                        <%: item.correo %>
                    </td>
                    <td>
                        <%: Html.ActionLink("Editar", "Edit", new { id = item.codigocliente }, new {@style = "color:blue"})%>
                        |
                        <%: Html.ActionLink("Ver Detalle", "Details", new { id = item.codigocliente }, new { @style = "color:blue" })%>
                        |
                        <%: Html.ActionLink("Eliminar", "Delete", new { id = item.codigocliente }, new { @style = "color:blue" })%>
                    </td>
                </tr>
                <% } %>
            </table>
            <p>
                <button type="submit" class="btn btn-success">
                    <%: Html.ActionLink("Nuevo Cliente", "Create", new { @style = "color:white" })%></button></p>
        </fieldset>
    </div>
</asp:Content>
