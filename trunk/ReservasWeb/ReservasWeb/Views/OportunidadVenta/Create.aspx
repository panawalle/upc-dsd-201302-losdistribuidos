<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Oportunidad>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Nuevo Servicio
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        NUEVO SERVICIO</h2>
<%--    <script src="../../Scripts/jquery.validate.min.js" type="text/javascript"></script>
    <script src="../../Scripts/jquery.validate.unobtrusive.min.js"></script>--%>
    <% using (Html.BeginForm())
       {%>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Datos del Servicio</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.codServicio) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.codServicio)%>
            <%: Html.ValidationMessageFor(model => model.codServicio)%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.nombreServicio) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.nombreServicio)%>
            <%: Html.ValidationMessageFor(model => model.nombreServicio)%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.cantidadServicio) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.cantidadServicio)%>
            <%: Html.ValidationMessageFor(model => model.cantidadServicio)%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.precioServicio) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.precioServicio)%>
            <%: Html.ValidationMessageFor(model => model.precioServicio)%>
        </div>

        <p>
            <input type="submit" value="Grabar Servicio" />
        </p>
    </fieldset>
    <% } %>
    <div>
        <%: Html.ActionLink("Regresar a la lista", "Index")%>
    </div>
</asp:Content>
