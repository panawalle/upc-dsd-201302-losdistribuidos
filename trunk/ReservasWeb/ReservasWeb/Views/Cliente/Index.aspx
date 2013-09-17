<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<ReservasWeb.Models.Cliente>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        LISTA DE CLIENTES</h2>
        
    <table>

        <tr>           
            <th>
                CODIGO
            </th>
            <th>
                DNI
            </th>
<%--            <th>
                TIPO
            </th>--%>
            <th>
                NOMBRE COMPLETO
            </th>
            <th>
                APELLIDO PATERNO
            </th>
            <th>
                APELLIDO MATERNO
            </th>
            <th>
                DIRECCION
            </th>
            <th>
                TELEFONO
            </th>
            <th>
                CELULAR
            </th>
            <th>
                CORREO
            </th>
	     <th>
                OPCIONES
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
    <%--        <td>
                <%: item.tipo %>
            </td>--%>
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
                <%: Html.ActionLink("Editar", "Edit", new { id = item.codigocliente }) %>
                |
                <%: Html.ActionLink("Ver Detalle", "Details", new { id = item.codigocliente })%>
                |
                <%: Html.ActionLink("Eliminar", "Delete", new { id = item.codigocliente })%>
            </td>
        </tr>
        <% } %>
    </table>
    <p>
        <%: Html.ActionLink("Nuevo Cliente", "Create") %>
    </p>
</asp:Content>
