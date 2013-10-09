<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%--<h2><%: ViewData["Message"] %></h2>--%>
    <div class="jumbotron">
        <div class="container">
            <h1>
                Bienvenidos!!</h1>
            <p>
                Una forma fácil, cómoda, rápida y segura de agendar su hora de atención en cualquier
                punto de la red de servicio técnico autorizado a lo largo de todo Perú. A través
                de este sistema usted tendrá la flexibilidad de escoger el día, la hora y el lugar
                para llevar su automóvil de acuerdo a su propia necesidad.</p>
            <p>
                <a class="btn btn-primary btn-lg">Leer más &raquo;</a></p>
        </div>
    </div>

      <div class="container">
      <div class="row">
        <div class="col-lg-4">
          <h2>Historia</h2>
          <p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui. </p>
          <p><a class="btn btn-default" href="#">View details &raquo;</a></p>
        </div>
        <div class="col-lg-4">
          <h2>Visión</h2>
          <p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui. </p>
          <p><a class="btn btn-default" href="#">View details &raquo;</a></p>
       </div>
        <div class="col-lg-4">
          <h2>Misión</h2>
          <p>Donec sed odio dui. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Vestibulum id ligula porta felis euismod semper. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.</p>
          <p><a class="btn btn-default" href="#">View details &raquo;</a></p>
        </div>
      </div>
</asp:Content>
