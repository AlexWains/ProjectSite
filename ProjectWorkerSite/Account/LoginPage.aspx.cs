using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_login_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["string"].ConnectionString);
        conn.Open();
        string command = "SELECT COUNT(*) FROM [tbl_Account] WHERE Username = @Username";
        SqlCommand cmd = new SqlCommand(command, conn);
        cmd.Parameters.AddWithValue("@Username", txt_usr.Text);
        int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());


        cmd.ExecuteNonQuery();
        conn.Close();

        if (count == 1)
        {
            SqlConnection inconn = new SqlConnection(ConfigurationManager.ConnectionStrings["string"].ConnectionString);
            inconn.Open();
            string inComm = "select Password from tbl_Account where Username = @Username";
            SqlCommand incmd = new SqlCommand(inComm, inconn);
            incmd.Parameters.AddWithValue("@Username", txt_usr.Text);
            string inpassword = incmd.ExecuteScalar().ToString();
            if (txt_pass.Text != "")
            {

                if (inpassword == txt_pass.Text.ToString())
                {
                    Session["CurrentUser_name"] = txt_usr.Text.ToString();
                    Response.Redirect("~/Member/Home.aspx");


                }
                else
                {
                    //error message password 
                    errormsg.Text = "Wrong Password";
                    errormsg.Visible = true;

                }
            }
            else
            {
                errormsg.Text = "Please Enter Password";
                errormsg.Visible = true;
            }

            incmd.ExecuteNonQuery();
            inconn.Close();
        }
        else
        {
            errormsg.Text = "Username Does not Exist";
            errormsg.Visible = true;
            //error message username
        }
    }

    protected void login_linkbtn_redirect_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegisterPage.aspx");
    }
}