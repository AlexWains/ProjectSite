using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CurrentUser_name"] != null)
        {
            usr_hello_lbl.Text = (string)Session["CurrentUser_name"];
            lbl_hello.Visible = true;
            usr_hello_lbl.Visible = true;

        }
        else
        {
            usr_hello_lbl.Visible = false;
            lbl_hello.Visible = false;

        }
    }

   
}