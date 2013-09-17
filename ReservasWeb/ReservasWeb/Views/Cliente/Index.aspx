<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Listado de Clientes
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Listado de Clientes</h2>

    <table>
        <tr>
            <th>OPCIONES</th>
            <th>
                DNI
            </th>
            <th>
                NOMBRES
            </th>
            <th>
                APELLIDOS
            </th>
            <th>
                CORREO
            </th>
            <th>
                SEXO
            </th>
            <th>
                FECHA DE NACIMIENTO
            </th>
            <th>
                DISTRITO
            </th>
            <th>
                PROVINCIA
            </th>
            <th>
                DEPARTAMENTO
            </th>
        </tr>

    <% foreach (var item in Model) { %>
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id = item.dnicliente })%> |
                <%: Html.ActionLink("Detalle", "Details", new { id = item.dnicliente })%> |
                <%: Html.ActionLink("Eliminar", "Delete", new { id = item.dnicliente })%>
            </td>
            <td>
                <%: item.dnicliente %>
            </td>
            <td>
                <%: item.nombrecliente %>
            </td>
            <td>
                <%: item.apellidocliente %>
            </td>
            <td>
                <%: item.correocliente %>
            </td>
            <td>
                <%: item.sexocliente %>
            </td>
            <td>
                <%: item.fecnacliente %>
            </td>
            <td>
                <%: item.distritocliente.codigodistrito %> - <%: item.distritocliente.nombredistrito %>
            </td>
            <td>
                <%: item.provinciacliente.codigoprovincia %> - <%: item.provinciacliente.nombreprovincia%>
            </td>
            <td>
               <%: item.departamentocliente.codigodepartamento %> - <%: item.departamentocliente.nombredepartamento%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Nuevo Cliente", "Create")%>
    </p>

</asp:Content>


