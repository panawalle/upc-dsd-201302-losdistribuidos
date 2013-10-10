<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Cliente>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Nuevo Cliente
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <% using (Html.BeginForm())
           {%>
        <%: Html.ValidationSummary(true) %>
        <fieldset>
            <legend>Nuevo Cliente</legend>
            <table border="0">
                <tr>
                    <td>
                        <div class="editor-label">
                            <%: Html.LabelFor(model => model.codigocliente) %>
                        </div>
                    </td>
                    <td>
                        <div class="editor-field">
                            <%: Html.TextBoxFor(model => model.codigocliente, new { @placeholder = "Ingrese código", @class = "form-control input-sm" })%>
                            <%: Html.ValidationMessageFor(model => model.codigocliente) %></div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="editor-label">
                            <%: Html.LabelFor(model => model.dnicliente) %>
                        </div>
                    </td>
                    <td>
                        <div class="editor-field">
                            <%: Html.TextBoxFor(model => model.dnicliente, new { @placeholder = "Ingrese el dni", @class = "form-control input-sm" })%>
                            <%: Html.ValidationMessageFor(model => model.dnicliente) %>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="editor-label">
                            <%: Html.LabelFor(model => model.nombrecliente) %>
                        </div>
                    </td>
                    <td>
                        <div class="editor-field">
                            <%: Html.TextBoxFor(model => model.nombrecliente, new { @placeholder = "Ingrese nombres", @class = "form-control input-sm" })%>
                            <%: Html.ValidationMessageFor(model => model.nombrecliente) %>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="editor-label">
                            <%: Html.LabelFor(model => model.apellidopaterno) %>
                        </div>
                    </td>
                    <td>
                        <div class="editor-field">
                            <%: Html.TextBoxFor(model => model.apellidopaterno, new { @placeholder = "Ingrese apellido", @class = "form-control input-sm" })%>
                            <%: Html.ValidationMessageFor(model => model.apellidopaterno) %>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="editor-label">
                            <%: Html.LabelFor(model => model.apellidomaterno) %>
                        </div>
                    </td>
                    <td>
                        <div class="editor-field">
                            <%: Html.TextBoxFor(model => model.apellidomaterno, new {  @class = "form-control input-sm" })%>
                            <%: Html.ValidationMessageFor(model => model.apellidomaterno) %>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="editor-label">
                            <%: Html.LabelFor(model => model.direccioncliente) %>
                        </div>
                    </td>
                    <td>
                        <div class="editor-field">
                            <%: Html.TextBoxFor(model => model.direccioncliente, new { @class = "form-control input-sm" })%>
                            <%: Html.ValidationMessageFor(model => model.direccioncliente) %>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="editor-label">
                            <%: Html.LabelFor(model => model.telefono) %>
                        </div>
                    </td>
                    <td>
                        <div class="editor-field">
                            <%: Html.TextBoxFor(model => model.telefono, new {@class = "form-control input-sm" })%>
                            <%: Html.ValidationMessageFor(model => model.telefono) %>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="editor-label">
                            <%: Html.LabelFor(model => model.celular) %>
                        </div>
                    </td>
                    <td>
                        <div class="editor-field">
                            <%: Html.TextBoxFor(model => model.celular, new { @class = "form-control input-sm" })%>
                            <%: Html.ValidationMessageFor(model => model.celular) %>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="editor-label">
                            <%: Html.LabelFor(model => model.correo) %>
                        </div>
                    </td>
                    <td>
                        <div class="editor-field">
                            <%: Html.TextBoxFor(model => model.correo, new { @class = "form-control input-sm" })%>
                            <%: Html.ValidationMessageFor(model => model.correo) %>
                        </div>
                    </td>
                </tr>
                <tr></tr>
                    <td><input type="submit" class="btn btn-success" value="Guardar" /></td>
                    <td><button type="submit" class="btn btn-success">
                        <%: Html.ActionLink("Regresar a la lista de Clientes", "Index", new { @style = "color:red" })%></button></td>
            </table>
        </fieldset>
        <% } %>
    </div>
</asp:Content>
