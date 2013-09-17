<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Cliente>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Nuevo Cliente
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        NUEVO CLIENTE</h2>
<%--    <script src="../../Scripts/jquery.validate.min.js" type="text/javascript"></script>
    <script src="../../Scripts/jquery.validate.unobtrusive.min.js"></script>--%>
    <% using (Html.BeginForm())
       {%>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Datos del Cliente</legend>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.dnicliente) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.dnicliente) %>
            <%: Html.ValidationMessageFor(model => model.dnicliente) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.nombrecliente) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.nombrecliente) %>
            <%: Html.ValidationMessageFor(model => model.nombrecliente) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.apellidocliente) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.apellidocliente) %>
            <%: Html.ValidationMessageFor(model => model.apellidocliente) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.correocliente) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.correocliente) %>
            <%: Html.ValidationMessageFor(model => model.correocliente) %>
        </div>
        <div class="editor-label">
        </div>
        <%: Html.LabelFor(model => model.sexocliente)%>
        <div class="editor-label">
            <%: Html.RadioButtonFor(model => model.sexocliente,"H") %>
            <%: Html.Label("Hombre") %>
            <%: Html.RadioButtonFor(model => model.sexocliente,"M")%>
            <%: Html.Label("Mujer") %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.fecnacliente) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.fecnacliente) %>
            <%: Html.ValidationMessageFor(model => model.fecnacliente) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.distritocliente) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.distritocliente)%>
            <%: Html.ValidationMessageFor(model => model.distritocliente)%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.provinciacliente) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.provinciacliente)%>
            <%: Html.ValidationMessageFor(model => model.provinciacliente)%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.departamentocliente) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.departamentocliente)%>
            <%: Html.ValidationMessageFor(model => model.departamentocliente)%>
        </div>
        <p>
            <input type="submit" value="Grabar Cliente" />
        </p>
    </fieldset>
    <% } %>
    <div>
        <%: Html.ActionLink("Regresar a la lista", "Index")%>
    </div>
</asp:Content>
