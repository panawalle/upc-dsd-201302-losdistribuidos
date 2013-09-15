<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    <table width="100%">
        <tr>
            <td colspan="4" align="center">
                <h2>
                    Listado de Vehículos</h2>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <fieldset style="border: 1; width: 98%">
                    <table width="98%">
                        <tr>
                            <td colspan="4" align="left">
                                Filtros de Consulta
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Placa
                            </td>
                            <td>
                                <asp:TextBox ID="txtPlaca" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                Color
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlColor" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Modelo
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlModelo" runat="server">
                                </asp:DropDownList>
                            </td>
                            <td>
                                Cliente
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlCliente" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" align="right">
                                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" />
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
    </form>
</asp:Content>
