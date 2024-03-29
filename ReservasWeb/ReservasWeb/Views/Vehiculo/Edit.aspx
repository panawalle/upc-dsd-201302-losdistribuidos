﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Vehiculo>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	UPC - Los Distribuidos
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Editar Vehículo</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Campos</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.placa) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.placa) %>
                <%: Html.ValidationMessageFor(model => model.placa) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.vin) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.vin) %>
                <%: Html.ValidationMessageFor(model => model.vin) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.anio) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.anio) %>
                <%: Html.ValidationMessageFor(model => model.anio) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.motor) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.motor) %>
                <%: Html.ValidationMessageFor(model => model.motor) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.contacto) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.contacto) %>
                <%: Html.ValidationMessageFor(model => model.contacto) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.usuario) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.usuario) %>
                <%: Html.ValidationMessageFor(model => model.usuario) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.fecha) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.fecha) %>
                <%: Html.ValidationMessageFor(model => model.fecha) %>
            </div>
            
            <p>
                <input type="submit" value="Guardar" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar al Listado", "Index") %>
    </div>

</asp:Content>

