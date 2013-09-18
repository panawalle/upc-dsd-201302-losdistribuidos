<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Oportunidad>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Editar Oportunidad
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>EDITAR OPORTUNIDAD</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Datos del Serivico</legend>
            
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
            
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.ValidateRequest) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.ValidateRequest) %>
                <%: Html.ValidationMessageFor(model => model.ValidateRequest) %>
            </div>
            
            <p>
                <input type="submit" value="Guardar" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar al listado", "Index") %>
    </div>

</asp:Content>

