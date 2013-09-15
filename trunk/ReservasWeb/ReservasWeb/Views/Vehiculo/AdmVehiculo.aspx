<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<ReservasWeb.Dominio.Vehiculo>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	AdmVehiculo
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>AdmVehiculo</h2>

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
                fecha
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
                <%: Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })%> |
                <%: Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ })%>
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
                <%: item.fecha %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

