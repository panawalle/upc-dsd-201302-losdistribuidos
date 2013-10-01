<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<ReservasWeb.Models.Vehiculo>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	UPC - Los Distribuidos
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Gestionar Vehículos</h2>

    <table>
        <tr>
            <th></th>
            <th>
                placa
            </th>
            <th>
                vin
            </th>
            <th>
                anio
            </th>
            <th>
                motor
            </th>
            <th>
                contacto
            </th>
            <th>
                usuario
            </th>
            <th>
                Color
            </th>
            <th>
                Modelo
            </th>
            <th>
                Cliente
            </th>
            
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { placa=item.placa }) %> |
                <%: Html.ActionLink("Detailles", "Details", new { placa = item.placa })%> |
                <%: Html.ActionLink("Eliminar", "Delete", new { placa = item.placa })%>
            </td>
            <td>
                <%: item.placa %>
            </td>
            <td>
                <%: item.vin %>
            </td>
            <td>
                <%: item.anio %>
            </td>
            <td>
                <%: item.motor %>
            </td>
            <td>
                <%: item.contacto %>
            </td>
            <td>
                <%: item.usuario %>
            </td>

            <td>
                <%: item.descColor %>
            </td>

            <td>
                <%: item.descModelo %>
            </td>

            <td>
                <%: item.nomCliente %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Nuevo Vehículo", "Create") %>
    </p>

</asp:Content>

