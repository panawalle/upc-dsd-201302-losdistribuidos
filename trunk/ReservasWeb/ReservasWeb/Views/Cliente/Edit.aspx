<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Cliente>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Editar Cliente
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>EDITAR CLIENTE</h2>

    <% using (Html.BeginForm()) {%>
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
                <%: Html.LabelFor(model => model.sexocliente) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.sexocliente) %>
                <%: Html.ValidationMessageFor(model => model.sexocliente) %>
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
                <%: Html.TextBoxFor(model => model.distritocliente.nombredistrito) %>
                <%: Html.ValidationMessageFor(model => model.distritocliente.codigodistrito) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.provinciacliente) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.provinciacliente.nombreprovincia) %>
                <%: Html.ValidationMessageFor(model => model.provinciacliente.codigoprovincia) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.departamentocliente) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.departamentocliente.nombredepartamento) %>
                <%: Html.ValidationMessageFor(model => model.departamentocliente.codigodepartamento) %>
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

