<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Listado de Clientes</h2>

    <table>
        <tr>
            <th></th>
            <th>
                DNI
            </th>
            <th>
                Nombres
            </th>
            <th>
                Apellidos
            </th>
            <th>
                Correo
            </th>
            <th>
                Sexo
            </th>
            <th>
                Fecha de Nacimiento
            </th>
            <th>
                Distrito
            </th>
            <th>
                Provincia
            </th>
            <th>
                Departamento
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id = item.dnicliente })%> |
                <%: Html.ActionLink("Detalles", "Details", new { id = item.dnicliente })%> |
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
                <%: item.distritocliente %> 
                <%--.distritocliente.codigodistrito %> - <%: item.distritocliente.nombredistrito %>--%>
            </td>
            <td>
            <%: item.provinciacliente %> 
               <%-- <%: item.provinciacliente.codigoprovincia %> - <%: item.provinciacliente.nombreprovincia%>--%>
            </td>
            <td>
            <%: item.departamentocliente %> 
               <%--<%: item.departamentocliente.codigodepartamento %> - <%: item.departamentocliente.nombredepartamento%>--%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear", "Create")%>
    </p>

</asp:Content>


