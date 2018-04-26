<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RegisterPage.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="register">
        <div id="head-lbls">
            <asp:Label Text="Create Account" ID="reg_lbl_head" CssClass="login-form"  runat="server"/>
        </div>

        <div class="reg-form">
            <asp:TextBox CssClass="textbox" ID="txt_usr" placeholder="Username" runat="server"   />
            <div class="error-label">
                <asp:Label  Text="" ID="usr_error" runat="server" />
            </div>
        </div>

        <div class="reg-form">
            <asp:TextBox CssClass="textbox" TextMode="Email" ID="txt_mail" placeholder="Email" runat="server"  />
            <div class="error-label">
                <asp:Label CssClass="error-label" Text="" ID="mail_error" runat="server" />
            </div>

        </div>

        <div class="reg-form">
            <asp:TextBox CssClass="textbox" TextMode="Password" ID="txt_pass" placeholder="Password" runat="server" />
            <div class="error-label">
                <asp:Label  Text="" ID="pass_error" runat="server" Visible="true" />
            </div>

        </div>
        
        <div class="reg-form">
            <asp:TextBox CssClass="textbox" TextMode="Password" ID="txt_conf_pass" placeholder="Confirm Password" runat="server" />
            <div class="error-label">
                <asp:Label Text="" ID="pass_conf_error" runat="server" Visible="false" />
            </div>

        </div>

        
        <asp:Button Cssclass="sumbit-buttons" Text="Create" ID="btn_reg" runat="server" OnClick="btn_reg_Click" />
        <div class="error-label">
            <asp:Label  Text="" ID="errormsg" runat="server" />
        </div>

        <div class="login-form" id="login_bottom">
            <div class="bottom_links">
                <asp:Label ID="reg_lbl" Text="Have an account?" runat="server"/>
                <asp:LinkButton CssClass="linkbtn_redirect" ID="reg_linkbtn_redirect" Text="Login" runat="server" OnClick="reg_linkbtn_redirect_Click" />
            </div>
            
        </div>
    </div>
</asp:Content>

