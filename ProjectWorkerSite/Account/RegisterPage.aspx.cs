using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        usr_error.Text = "";
        mail_error.Text = "";
        pass_error.Text = "";
        pass_conf_error.Text = "";
        errormsg.Text = "";



    }

    protected void reg_linkbtn_redirect_Click(object sender, EventArgs e)
    {
        Response.Redirect("LoginPage.aspx");
    }

    private bool ConfPass()
    {
        if (txt_conf_pass.Text != "" && txt_pass.Text != "")
        {

            if (txt_pass.Text == txt_conf_pass.Text)
            {
                return true;
            }
        }
        pass_conf_error.Text = "Passwords do not match";
        return false;
    }

    private bool ConfUsername()
    {
        if (txt_usr.Text != "")
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["string"].ConnectionString);
            conn.Open();
            string command = "select count(*) from tbl_Account where Username = @Username";
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@Username", txt_usr.Text);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            cmd.ExecuteNonQuery();
            conn.Close();
            if (count != 1)
            {
                return true;
            }
            
        }
        usr_error.Text = "Username is in use";
        return false;
    }

    private bool ConfMail()
    {
        if (txt_mail.Text != "")
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["string"].ConnectionString);
            conn.Open();
            string command = "select count(*) from tbl_Account where Email = @Email";
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@Email", txt_mail.Text);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            cmd.ExecuteNonQuery();
            conn.Close();
            if (count != 1)
            {
                return true;
            }
            
        }
        mail_error.Text = "Email is in use";
        return false;
    }

    protected void btn_reg_Click(object sender, EventArgs e)
    {
        bool k1,k2,k3;
        k1 = ConfMail();
        k2 = ConfPass();
        k3 = ConfUsername();
        if (k1&&k2&&k3)
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["string"].ConnectionString);
            conn.Open();
            string command = "if not exists (select * from tbl_Account where Username = @Username OR Email = @Email) Begin Insert Into tbl_Account Values(@Username, @Email, @Password) END";
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddWithValue("@Username", txt_usr.Text);
            cmd.Parameters.AddWithValue("@Email", txt_mail.Text);
            cmd.Parameters.AddWithValue("@Password", txt_pass.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            Session["CurrentUser_name"] = txt_usr.Text;
            Response.Redirect("~/Member/Home.aspx");
        }
        

    }
}