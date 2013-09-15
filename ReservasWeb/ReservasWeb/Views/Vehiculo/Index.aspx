<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    <center>
        <fieldset>
            <table width="100%">
                <tr>
                    <td colspan="4" class="titulo">
                        Gestión de Vehículos
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <fieldset style="width: 97.5%">
                            <table width="100%" align="left">
                                <tr>
                                    <td colspan="9" class="subtitulo">
                                        Filtros de Consulta
                                    </td>
                                </tr>
                                <tr>
                                    <td width="10%">
                                        Placa
                                    </td>
                                    <td width="10%">
                                        <asp:TextBox ID="txtPlaca" runat="server"></asp:TextBox>
                                    </td>
                                    <td width="10%">
                                        Cliente
                                    </td>
                                    <td width="10%">
                                        <asp:DropDownList ID="ddlCliente" runat="server">
                                            <asp:ListItem Value="0">Todos</asp:ListItem>
                                            <asp:ListItem Value="1">Cabañas Valdiviezo, Luis Antonio</asp:ListItem>
                                            <asp:ListItem Value="2">Cermeño Negrón, Lorena</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td width="10%">
                                        Modelo
                                    </td>
                                    <td width="10%">
                                        <asp:DropDownList ID="ddlModelo" runat="server">
                                            <asp:ListItem Value="0">Todos</asp:ListItem>
                                            <asp:ListItem Value="1">i10</asp:ListItem>
                                            <asp:ListItem Value="2">i30</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td width="10%">
                                        Color
                                    </td>
                                    <td width="10%">
                                        <asp:DropDownList ID="ddlColor" runat="server">
                                            <asp:ListItem Value="0">Todos</asp:ListItem>
                                            <asp:ListItem Value="1">Rojo</asp:ListItem>
                                            <asp:ListItem Value="2">Amarillo</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td width="10%">
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="9" align="left">
                                        <table width="100%">
                                            <tr>
                                                <td align="left">
                                                    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo Vehículo" class="button medium blue" />
                                                </td>
                                                <td align="right">
                                                    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" class="button medium blue" />
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </fieldset>
                    </td>
                </tr>
                <tr>
                    <td>
                        <fieldset style="width: 97.5%">
                            <table width="100%">
                                <tr>
                                    <td class="subtitulo">
                                        Listado de Vehículos
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:GridView ID="gvListado" runat="server" BackColor="White" BorderColor="#CCCCCC"
                                            BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="100%" AutoGenerateColumns="False">
                                            <FooterStyle BackColor="White" ForeColor="#000066" />
                                            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                                            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                            <RowStyle ForeColor="#000066" />
                                            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                            <SortedAscendingHeaderStyle BackColor="#007DBB" />
                                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                            <SortedDescendingHeaderStyle BackColor="#00547E" />
                                            <Columns>
                                                <asp:BoundField DataField="PLACA" HeaderText="Placa" />
                                                <asp:BoundField DataField="VIN" HeaderText="VIN" />
                                                <asp:BoundField DataField="Color" HeaderText="Color" />
                                                <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                                                <asp:BoundField DataField="Anio" HeaderText="Anio" />
                                                <asp:BoundField DataField="Motor" HeaderText="Motor" />
                                                <asp:BoundField DataField="Contacto" HeaderText="Contacto" />
                                                <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
                                                <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                                                <asp:BoundField DataField="Cliente" HeaderText="Cliente" />
                                                <asp:TemplateField HeaderText="Editar">
                                                
                                                    <ItemTemplate>
                                                        <asp:ImageButton ID="btnEditar" runat="server" />
                                                    </ItemTemplate>
                                                
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Desactivar">
                                                    <ItemTemplate>
                                                        <asp:ImageButton ID="btnDesactivar" runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                        </fieldset>
                    </td>
                </tr>
            </table>
        </fieldset>
    </center>
    </form>
</asp:Content>
