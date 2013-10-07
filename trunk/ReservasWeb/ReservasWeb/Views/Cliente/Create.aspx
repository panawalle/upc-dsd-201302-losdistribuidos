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
            <table>
                <tr>
                    <td>
                        <div class="editor-label">
                            <%: Html.LabelFor(model => model.codigocliente) %>
                        </div>
                    </td>
                    <td>
                        <div class="editor-field">
                            <%: Html.TextBoxFor(model => model.codigocliente) %>
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
                            <%: Html.TextBoxFor(model => model.dnicliente) %>
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
                            <%: Html.TextBoxFor(model => model.nombrecliente) %>
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
                            <%: Html.TextBoxFor(model => model.apellidopaterno) %>
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
                            <%: Html.TextBoxFor(model => model.apellidomaterno) %>
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
                            <%: Html.TextBoxFor(model => model.direccioncliente) %>
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
                            <%: Html.TextBoxFor(model => model.telefono) %>
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
                            <%: Html.TextBoxFor(model => model.celular) %>
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
                            <%: Html.TextBoxFor(model => model.correo) %>
                            <%: Html.ValidationMessageFor(model => model.correo) %>
                        </div>
                    </td>
                </tr>
            </table>
            <p>
            </p>
            <p>
                <input type="submit" class="btn btn-success" value="Guardar" />
                <button type="submit" class="btn btn-success">
                    <%: Html.ActionLink("Regresar a la lista de Clientes", "Index", new { @style = "color:red" })%></button>
            </p>
        </fieldset>
        <% } %>
    </div>
</asp:Content>
