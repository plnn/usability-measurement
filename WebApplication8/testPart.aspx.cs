using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class testPart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Session["val"].ToString();
            TextBox2.Text = Session["val2"].ToString();


        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("test_question.aspx");
        }

    }
}