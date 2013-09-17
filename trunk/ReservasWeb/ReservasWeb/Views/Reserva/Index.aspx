<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<ReservasWeb.Models.Reserva>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Consultar Reserva
    </h2>
    <% using (Html.BeginForm("Index", "Reserva")) %>
    <% { %>
    <table>
        <tr>
            <td>
                Código:
            </td>
            <td>
                <%= Html.TextBox("codigo")%>
            </td>
        </tr>
        <tr>
            <td>
                Nro. Reserva:
            </td>
            <td>
                <%= Html.TextBox("nroreserva")%>
            </td>
        </tr>
        <tr>
            <td>
                Placa:
            </td>
            <td>
                <%= Html.TextBox("placa")%>
            </td>
        </tr>
        <tr>
            <td>
                <input type="submit" value="Buscar" />
            </td>
        </tr>
        <tr>
            <th style="width: 5%">
                Código
            </th>
            <th style="width: 5%">
                Nro. Reserva
            </th>
            <th style="width: 5%">
                Fecha
            </th>
            <%--<th style ="width:15%">
                Num. Express
            </th>--%>
            <th style="width: 15%">
                Asesor
            </th>
            <th style="width: 20%">
                Placa - Cliente
            </th>
            <th style="width: 20%">
                Marca - Modelo - Color
            </th>
            <th style="width: 5%">
                Estado
            </th>
            <th style="width: 25%">
                Opciones
            </th>
        </tr>
        <% if (Model != null)
           { %>
            <% foreach (var item in Model)
               { %>
            <tr>
                <td style="width: 5%">
                    <%: item.codigo %>
                </td>
                <td style="width: 5%">
                    <%: item.nroreserva %>
                </td>
                <td style="width: 5%">
                    <%: String.Format("{0:d}", item.fecha) %>
                </td>
                <%--<td style ="width:15%">
                    <%: item.numexpress %>
                </td>--%>
                <td style="width: 15%">
                    <%: item.asesor.codigo %>
                    -
                    <%: item.asesor.nombre %>
                </td>
                <td style="width: 20%">
                    <%: item.vehiculo.placa %>
                    -
                    <%: item.vehiculo.cliente.nombrecliente %>
                    <%: item.vehiculo.cliente.apellidopaterno %>
                </td>
                <td style="width: 20%">
                    <%: item.vehiculo.modelo.marca.descripcion %>
                    -
                    <%: item.vehiculo.modelo.descripcion%>
                    -
                    <%: item.vehiculo.color.descripcion %>
                </td>
                <td style="width: 5%">
                    <%: item.estado %>
                </td>
                <td style="width: 25%">
                    <%: Html.ActionLink("Ver Detalle", "Details", new { codigo=item.codigo }) %>
                    |
                    <%: Html.ActionLink("Reserva Atendida", "OrdenServicio", new { codigo=item.codigo }) %>
                    |
                    <%: Html.ActionLink("Cancelar", "Cancelar", new { codigo = item.codigo })%>
                </td>
            </tr>
            <% } %>
        <% } %>
        <% else { %>
            <tr>
                <td colspan ="8">
                    <b>No existen reservas que coincidan con los parámetros enviados.</b>
                </td>
            </tr>
        <% } %>
    </table>
    <p>
        <%: Html.ActionLink("Nueva Reserva", "Create") %>
    </p>
    <% } %>
</asp:Content>
