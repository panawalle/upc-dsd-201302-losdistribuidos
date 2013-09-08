<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Cliente>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Crear</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Campos</legend>
            
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
                <%--<%: Html.LabelFor(model => model.sexocliente) %>--%>
                <%: Html.LabelFor(model => model.sexocliente)%> 
                <%: Html.RadioButtonFor(model => model.sexocliente,"H") %> <%: Html.Label("Hombre") %>

                <%: Html.RadioButtonFor(model => model.sexocliente,"M")%> <%: Html.Label("Mujer") %>
            </div>

            <%--<div class="editor-field">
                <%: Html.TextBoxFor(model => model.sexocliente) %>
                <%: Html.ValidationMessageFor(model => model.sexocliente) %>
            </div>--%>
            
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

           <%--<div class="editor-label">
                <%: Html.LabelFor(model => model.contrasena) %>
            </div>
            <div class="editor-field">
                <%: Html.PasswordFor(model => model.contrasena)%>
                <%: Html.ValidationMessageFor(model => model.contrasena)%>
            </div> --%>

             <%--<div class="editor-label">
               <%: Html.Label("Repetir Contraseña")%> 
            </div>

            <div class="editor-field">
                <%: Html.PasswordFor(model => model.Rpass)%>
                <%: Html.ValidationMessageFor(model => model.Rpass)%>
            </div> --%>
            
            <p>
                <input type="submit" value="Crear" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar a la lista", "Index")%>
    </div>

</asp:Content>
