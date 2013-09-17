<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Cliente>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.codigocliente) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.codigocliente) %>
                <%: Html.ValidationMessageFor(model => model.codigocliente) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.dnicliente) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.dnicliente) %>
                <%: Html.ValidationMessageFor(model => model.dnicliente) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.tipo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.tipo) %>
                <%: Html.ValidationMessageFor(model => model.tipo) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.nombrecliente) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.nombrecliente) %>
                <%: Html.ValidationMessageFor(model => model.nombrecliente) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.apellidopaterno) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.apellidopaterno) %>
                <%: Html.ValidationMessageFor(model => model.apellidopaterno) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.apellidomaterno) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.apellidomaterno) %>
                <%: Html.ValidationMessageFor(model => model.apellidomaterno) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.direccioncliente) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.direccioncliente) %>
                <%: Html.ValidationMessageFor(model => model.direccioncliente) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.telefono) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.telefono) %>
                <%: Html.ValidationMessageFor(model => model.telefono) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.celular) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.celular) %>
                <%: Html.ValidationMessageFor(model => model.celular) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.correo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.correo) %>
                <%: Html.ValidationMessageFor(model => model.correo) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.ValidateRequest) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.ValidateRequest) %>
                <%: Html.ValidationMessageFor(model => model.ValidateRequest) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

