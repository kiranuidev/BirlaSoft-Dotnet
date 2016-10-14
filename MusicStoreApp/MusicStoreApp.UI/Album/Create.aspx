<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="MusicStoreApp.UI.Album.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <section id="createAlbumFrm">
        <div class="form-horizontal">
            <h4>Create Album</h4>
            <hr />
           
            <div class="form-group">
                <asp:Label runat="server"  CssClass="col-md-2 control-label">Genre</asp:Label>
                <div class="col-md-3">
                    <asp:DropDownList runat="server" ID="ddlGenre"
                         CssClass="form-control" 
                        />
                    <asp:RequiredFieldValidator 
                        runat="server"
                        ID="vldGenre"
                         ControlToValidate="ddlGenre"
                        ErrorMessage="Genre Required"></asp:RequiredFieldValidator>
                   
                </div>
            </div>
             <div class="form-group">
                <asp:Label runat="server"  CssClass="col-md-2 control-label">Artist</asp:Label>
                <div class="col-md-3">
                    <asp:DropDownList runat="server" ID="ddlArtist"
                         CssClass="form-control" 
                        />
                   
                </div>
            </div>
             <div class="form-group">
                <asp:Label runat="server"  CssClass="col-md-2 control-label">Name</asp:Label>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtName"
                         CssClass="form-control" 
                        />
                     <asp:RequiredFieldValidator 
                        runat="server"
                        ID="vldName"
                         ControlToValidate="txtName"
                         CssClass="txt-danger"
                        ErrorMessage="Name Required"></asp:RequiredFieldValidator>
                      <asp:RegularExpressionValidator 
                        runat="server"
                        ID="vldNameRegex"
                         ControlToValidate="txtName"
                         CssClass="txt-danger"
                          ValidationExpression="[a-zA-Z ]*$"
                        ErrorMessage="Invalid Name"></asp:RegularExpressionValidator>
                   
                </div>
            </div>
             <div class="form-group">
                <asp:Label runat="server"  CssClass="col-md-2 control-label">Price</asp:Label>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtPrice"
                         CssClass="form-control" 
                        />
                      <asp:RegularExpressionValidator 
                        runat="server"
                        ID="regexPrice"
                         ControlToValidate="txtPrice"
                         CssClass="txt-danger"
                          ValidationExpression="[0-9]*$"
                        ErrorMessage="Invalid Price"></asp:RegularExpressionValidator>
                   
                </div>
            </div>
             <div class="form-group">
                <asp:Label runat="server"  CssClass="col-md-2 control-label">URL</asp:Label>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="AlbumArtUrl"
                         CssClass="form-control" 
                        />
                   
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <asp:Button runat="server" OnClick="CreateAlbum"  Text="Create" CssClass="btn btn-default" />
                </div>
            </div>
        </div>
        <p>
            <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled">Register as a new user</asp:HyperLink>
        </p>
        <p>
            <%-- Enable this once you have account confirmation enabled for password reset functionality
                    <asp:HyperLink runat="server" ID="ForgotPasswordHyperLink" ViewStateMode="Disabled">Forgot your password?</asp:HyperLink>
            --%>
        </p>
    </section>

</asp:Content>
