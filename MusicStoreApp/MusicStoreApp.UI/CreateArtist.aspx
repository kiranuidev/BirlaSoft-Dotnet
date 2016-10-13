<%@ Page Title="Create Artist" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="CreateArtist.aspx.cs" Inherits="MusicStoreApp.UI.CreateArtist" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section id="loginForm">
        <div class="form-horizontal">
            <h4>Create Artist</h4>
            <hr />
           
            <div class="form-group">
                <asp:Label runat="server"  CssClass="col-md-2 control-label">Artist</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="txtArtist"
                         CssClass="form-control" 
                        />
                   <%-- <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                        CssClass="text-danger" ErrorMessage="The email field is required." />--%>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <asp:Button runat="server" OnClick="Create"  Text="Create" CssClass="btn btn-default" />
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
