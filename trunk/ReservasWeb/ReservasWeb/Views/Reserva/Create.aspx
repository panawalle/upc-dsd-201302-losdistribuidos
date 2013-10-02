<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MVC.Models.Reserva>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
    <link rel="stylesheet" href="/resources/demos/style.css" />
    <script>

        $(function () {
            $(function () {
                $("#fecha1").datepicker({ dateFormat: 'dd/mm/yy',minDate:0 }).val();
            });
            $(function () {
                $("#fecha2").datepicker({ dateFormat: 'dd/mm/yy', minDate: 0 }).val();
            });
        });

    </script>

    <h2>
        Registrar Reserva</h2>
    <% using (Html.BeginForm("consultar", "Reserva")) %>
    <% { %>
    <fieldset style="font-family:Verdana; font-size:10px">
        <legend>Disponibilidad de Reserva</legend>
        <table width="100%" style="font-family:Verdana; font-size:10px">
            <tr>
                <td>
                    Fecha:
                </td>
                <td>
                    <%: Html.TextBoxFor(model => model.fecha, new { id = "fecha1" })%>
                    <%--<input type="text" id="fechaConsulta" />--%>
                </td>
                <td>
                    <input type="submit" value="Buscar" style="font-family:Verdana; font-size:11px" />
                </td>
            </tr>
            <% if (Model.horario != null)
               { %>
            <tr style ="background-color:#CEE3F6">
                <td style="width: 10%" align="center"><b>
                    <%: Model.horario.horario %></b>
                </td>
                <td style="width: 15%" align="center"><b>
                    <%: Model.horario.dia1 %></b>
                </td>
                <td style="width: 15%" align="center"><b>
                    <%: Model.horario.dia2 %></b>
                </td>
                <td style="width: 15%" align="center"><b>
                    <%: Model.horario.dia3 %></b>
                </td>
                <td style="width: 15%" align="center"><b>
                    <%: Model.horario.dia4 %></b>
                </td>
                <td style="width: 15%" align="center"><b>
                    <%: Model.horario.dia5 %></b>
                </td>
                <td style="width: 15%" align="center"><b>
                    <%: Model.horario.dia6 %></b>
                </td>
            </tr>
            <% foreach (var item2 in Model.horario.horarioBody)
               { %>
            <tr>
                <td style="width: 10%;background-color:#CEE3F6"><b>
                    <%: item2.horario %></b>
                </td>
                <td style="width: 15%">
                    <%: item2.dia1 %>
                </td>
                <td style="width: 15%">
                    <%: item2.dia2 %>
                </td>
                <td style="width: 15%">
                    <%: item2.dia3 %>
                </td>
                <td style="width: 15%">
                    <%: item2.dia4 %>
                </td>
                <td style="width: 15%">
                    <%: item2.dia5 %>
                </td>
                <td style="width: 15%">
                    <%: item2.dia6 %>
                </td>
            </tr>
            <% } %>
            <% } %>
            <% else
               { %>
            <tr>
                <td colspan="7">
                    <b>Ingrese una fecha para consultar la disponibilidad.</b>
                </td>
            </tr>
            <% } %>
        </table>
    </fieldset>
    <% } %>
    <% using (Html.BeginForm())
       {%>
    <%: Html.ValidationSummary(true) %>
    <fieldset style="font-family:Verdana; font-size:10px">
        <legend>Datos de Reserva</legend>
        <table width="100%" style="font-family:Verdana; font-size:10px">
            <tr>
                <td width="40%">
                    <table width="100%">
                        <tr>
                            <td width="25%">
                                <b>Nro. Reserva: </b>
                            </td>
                            <td>
                                <%: Html.TextBoxFor(model => model.nroreserva) %>
                                <%: Html.ValidationMessageFor(model => model.nroreserva) %>
                            </td>
                        </tr>
                        <tr>
                            <td width="25%">
                                <b>Fecha: </b>
                            </td>
                            <td>
                                <%: Html.TextBoxFor(model => model.fecha, new { id = "fecha2" })%>
                                <%: Html.ValidationMessageFor(model => model.fecha)%>
                            </td>
                        </tr>
                        <tr>
                            <td width="25%">
                                <b>Num. Express: </b>
                            </td>
                            <td>
                                <%: Html.TextBoxFor(model => model.numexpress) %>
                                <%: Html.ValidationMessageFor(model => model.numexpress) %>
                            </td>
                        </tr>
                        <tr>
                            <td width="25%">
                                <b>Hora: </b>
                            </td>
                            <td>
                                <%: Html.TextBoxFor(model => model.hora) %>
                                <%: Html.ValidationMessageFor(model => model.hora) %>
                            </td>
                        </tr>
                        <tr>
                            <td width="25%">
                                <b>Asesor: </b>
                            </td>
                            <td>
                                <%: Html.TextBoxFor(model => model.asesor.codigo) %>
                                <%: Html.ValidationMessageFor(model => model.asesor.codigo) %>
                            </td>
                        </tr>
                        <tr>
                            <td width="25%">
                                <b>Vehiculo: </b>
                            </td>
                            <td>
                                <%: Html.TextBoxFor(model => model.vehiculo.placa) %>
                                <%: Html.ValidationMessageFor(model => model.vehiculo.placa)%>
                            </td>
                        </tr>
                    </table>
                </td>
                <% } %>
                <td valign="top" width="60%">
                    <% using (Html.BeginForm("agregarServicio", "Reserva")) %>
                    <% { %>
                    <table width="100%">
                        <tr>
                            <td width="10%">
                                <b>Servicio: </b>
                            </td>
                            <td width="10%">
                                <%= Html.TextBox("codOperSer")%>
                            </td>
                            <td width="80%">
                                <input type="submit" value="Agregar Servicio" style="font-family:Verdana; font-size:11px"/>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <table width="100%">
                                    <% if (Model.reservaDetalle != null)
                                       { %>
                                    <% foreach (var item4 in Model.reservaDetalle)
                                       { %>
                                    <tr>
                                        <td style="width: 3%">
                                            <%: item4.servicio.codOperSer %>
                                        </td>
                                        <td style="width: 3%">
                                            <%: item4.servicio.descripcion %>
                                        </td>
                                        <td style="width: 3%">
                                            <%: item4.servicio.precio %>
                                        </td>
                                    </tr>
                                    <% } %>
                                    <% } %>
                                    <% else
                                       { %>
                                    <tr>
                                        <td colspan="3">
                                            <b>Ingrese un código de servicio para consultar.</b>
                                        </td>
                                    </tr>
                                    <% } %>
                                </table>
                            </td>
                        </tr>
                    </table>
                    <% } %>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="left">
                    <input type="submit" value="Guardar" style="font-family:Verdana; font-size:11px" />
                </td>
            </tr>
        </table>
        <p>
        </p>
    </fieldset>
    <div>
        <%: Html.ActionLink("Regresar", "Index") %>
    </div>
</asp:Content>
