<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="login">
        <div id="head-lbls">
            
            <asp:Label Text="Login" ID="login_lbl_head" CssClass="login-form"  runat="server"/>

        </div>

        <div class="login-form">
            <asp:TextBox CssClass="textbox" ID="txt_usr" placeholder="Username" runat="server" />
            <div class="error-label">
                <asp:Label  Text="" ID="usr_error" runat="server" />
            </div>
        </div>

        

        <div class="login-form">
            <asp:TextBox CssClass="textbox" TextMode="Password" ID="txt_pass" placeholder="Password" runat="server" />
            <div class="error-label">
                <asp:Label  Text="" ID="pass_error" runat="server" Visible="true" />
            </div>

        </div>
        
        

        <asp:Button CssClass="sumbit-buttons" Text="Login" ID="btn_login" runat="server" OnClick="btn_login_Click" />
        
        <div class="error-label">
            <asp:Label  Text="" ID="errormsg" runat="server" />
        </div>

        <div class="login-form" id="login_bottom">
            <div class="bottom_links">
                <asp:Label ID="lbl_bottom1" Text="Don't have an account?" runat="server" />
                <asp:LinkButton CssClass="linkbtn_redirect" Text="Create One" ID="login_linkbtn_redirect" runat="server" OnClick="login_linkbtn_redirect_Click" />

                

            </div>
            
        </div>
    </div>
</asp:Content>

