<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Listado de Servicios
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Listado de Servicios</h2>
    <p>
        Codigo: <input id="Text1" type="text" />
        Nombre cliente: <input id="Text2" type="text" />
        Fecha: <input id="Text3" type="text" />
    </p>
    
    <table>
        <tr>
            <th>OPCIONES</th>
            <th>
                CODIGO
            </th>
            <th>
                NOMBRE
            </th>
            <th>
                CANTIDAD
            </th>
            <th>
                PRECIO
            </th> 
        </tr>

    <% foreach (var item in Model) { %>
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id = item.codServicio })%> |
                <%: Html.ActionLink("Detalle", "Details", new { id = item.codServicio })%> |
                <%: Html.ActionLink("Eliminar", "Delete", new { id = item.codServicio })%>
            </td>
            <td>
                <%: item.codServicio%>
            </td>
            <td>
                <%: item.nombreServicio %>
            </td>
            <td>
                <%: item.cantidadServicio %>
            </td>
            <td>
                <%: item.precioServicio %>
            </td>
           
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Nuevo Servicio", "Create")%>
    </p>

</asp:Content>


