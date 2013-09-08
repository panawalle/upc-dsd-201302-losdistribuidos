<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReservasWeb.Models.Cliente>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Delete</h2>

    <h3>Are you sure you want to delete this?</h3>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">dnicliente</div>
        <div class="display-field"><%: Model.dnicliente %></div>
        
        <div class="display-label">nombrecliente</div>
        <div class="display-field"><%: Model.nombrecliente %></div>
        
        <div class="display-label">apellidocliente</div>
        <div class="display-field"><%: Model.apellidocliente %></div>
        
        <div class="display-label">correocliente</div>
        <div class="display-field"><%: Model.correocliente %></div>
        
        <div class="display-label">sexocliente</div>
        <div class="display-field"><%: Model.sexocliente %></div>
        
        <div class="display-label">fecnacliente</div>
        <div class="display-field"><%: Model.fecnacliente %></div>
        
        <div class="display-label">distritocliente</div>
        <div class="display-field"><%: Model.distritocliente %></div>
        
        <div class="display-label">provinciacliente</div>
        <div class="display-field"><%: Model.provinciacliente %></div>
        
        <div class="display-label">departamentocliente</div>
        <div class="display-field"><%: Model.departamentocliente %></div>
        
        <div class="display-label">ValidateRequest</div>
        <div class="display-field"><%: Model.ValidateRequest %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Delete" /> |
		    <%: Html.ActionLink("Back to List", "Index") %>
        </p>
    <% } %>

</asp:Content>

