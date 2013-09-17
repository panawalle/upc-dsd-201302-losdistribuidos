<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<ReservasWeb.Models.Reserva>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    UPC - Los Distribuidos
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    <h2>
        Listado de Reservas</h2>
    <% using (Html.BeginForm())
       {%>
    <%: Html.ValidationSummary(true) %>
    <%--  <div class="editor-label">
        <%: Html.LabelFor(model => model.codigo) %>
    </div>
    <div class="editor-field">
        <%: Html.TextBoxFor(model => model.placa) %>
        <%: Html.ValidationMessageFor(model => model.placa) %>
    </div>--%>
    <table width="100%">
        <tr>
            <td>
                Código
            </td>
            <td>
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
            </td>
            <td>
                Reserva
            </td>
            <td>
                <asp:TextBox ID="txtReserva" runat="server"></asp:TextBox>
            </td>
            <td>
                Asesor
            </td>
            <td>
                <asp:TextBox ID="txtAsesor" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="8" align="right">
                <%: Html.ActionLink("Buscar", "Index", new { codigo = txtCodigo.Text, nroreserva = txtReserva.Text, codigoAsesor = txtAsesor.Text })%>
            </td>
        </tr>
        <tr>
            <td>
                Código
            </td>
            <td>
                # Reserva
            </td>
            <td>
                Fecha Reserva
            </td>
            <td>
                Num. Express
            </td>
            <td>
                Estado
            </td>
            <td>
                Asesor
            </td>
            <td>
                Placa Vehículo
            </td>
            <td>
                Opciones
            </td>
        </tr>
        <% foreach (var item in Model)
           { %>
        <tr>
            <td>
                <%: item.codigo%>
            </td>
            <td>
                <%: item.nroreserva%>
            </td>
            <td>
                <%: String.Format("{0:g}", item.fecha)%>
            </td>
            <td>
                <%: item.numexpress%>
            </td>
            <td>
                <%: item.estado%>
            </td>
            <td>
                <%: item.asesor.nombre%>
            </td>
            <td>
                <%: item.vehiculo.placa%>
            </td>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { /* id=item.PrimaryKey */ })%>
                |
                <%: Html.ActionLink("Detalles", "Details", new { /* id=item.PrimaryKey */ })%>
                |
                <%: Html.ActionLink("Eliminar", "Delete", new { /* id=item.PrimaryKey */ })%>
            </td>
        </tr>
        <% }
       } %>
    </table>
    <p>
        <%: Html.ActionLink("Nueva Reserva", "Create") %>
    </p>
    </form>
</asp:Content>
