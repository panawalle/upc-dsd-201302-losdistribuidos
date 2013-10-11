<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<ReservasWeb.Models.Reserva>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <center>
        <table width="95%">
            <tr>
                <td>
                    <h2 style="text-align: left">
                        Consultar Reserva</h2>
                    <% using (Html.BeginForm("Index", "Reserva")) %>
                    <% { %>
                    <table style="font-family: Verdana; font-size: 9px">
                        <tr >
                           <td colspan="9" style="font-size: 10px; font-weight: bold; color: Red">
                            <%= ViewData["Error"] %>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Código:
                            </td>
                            <td>
                                <%= Html.TextBox("codigo")%>
                            </td>
                            <td>
                                Nro. Reserva:
                            </td>
                            <td>
                                <%= Html.TextBox("nroreserva")%>
                            </td>
                            <td>
                                Placa:
                            </td>
                            <td>
                                <%= Html.TextBox("placa")%>
                            </td>
                            <td>
                                Estado:
                            </td>
                            <td>
                                <%: Html.DropDownList("codestado", ViewData["Estados"] as List<SelectListItem>)%>
                            </td>
                            <td style="width: 10px">
                            </td>
                            <td>
                                <input type="submit" value="Buscar" style="font-family: Verdana; font-size: 10px;
                                    height: 25px" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="9" height="20px">
                            </td>
                        </tr>
                    </table>
                    <table width="100%" class="table table-hover">
                        <tr>
                            <th style="width: 3%">
                                Código
                            </th>
                            <th style="width: 3%">
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
                            <th style="width: 29%">
                                Opciones
                            </th>
                        </tr>
                        <% if (Model != null)
                           { %>
                        <% foreach (var item in Model)
                           { %>
                        <tr>
                            <td style="width: 3%">
                                <%: item.codigo %>
                            </td>
                            <td style="width: 3%">
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
                            <td style="width: 24%">
                                <%: item.vehiculo.placa %>
                                -
                                <%: item.vehiculo.cliente.nombrecliente %>
                                <%: item.vehiculo.cliente.apellidopaterno %>
                            </td>
                            <td style="width: 25%">
                                <%: item.vehiculo.modelo.marca.descripcion %>
                                -
                                <%: item.vehiculo.modelo.descripcion%>
                                -
                                <%: item.vehiculo.color.descripcion %>
                            </td>
                            <td style="width: 10%">
                                <%: item.estado %>
                            </td>
                            <td style="width: 15%; color: blue">
                                <%: Html.ActionLink("Ver Detalle", "Details", new { codigo=item.codigo }) %>
                                |
                                <%: Html.ActionLink("Cancelar", "Cancelar", new { codigo = item.codigo })%>
                            </td>
                        </tr>
                        <% } %>
                        <% } %>
                        <% else
                           { %>
                        <tr>
                            <td colspan="9">
                                <b>No existen reservas que coincidan con los parámetros enviados.</b>
                            </td>
                        </tr>
                        <% } %>
                    </table>
                    <p class="btn btn-success">
                        <%: Html.ActionLink("Nueva Reserva", "Create", new { @style = "color:white" })%></p>
                    <%--    <p>
        <%: Html.ActionLink("Nueva Reserva", "Create") %>
    </p>--%>
                    <% } %>
                    <%--<table>
        <tr>
            <th></th>
            <th>
                codigo
            </th>
            <th>
                nroreserva
            </th>
            <th>
                fecha
            </th>
            <th>
                numexpress
            </th>
            <th>
                estado
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
                <%: item.codigo %>
            </td>
            <td>
                <%: item.nroreserva %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.fecha) %>
            </td>
            <td>
                <%: item.numexpress %>
            </td>
            <td>
                <%: item.estado %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>--%>
                </td>
            </tr>
        </table>
    </center>
</asp:Content>
