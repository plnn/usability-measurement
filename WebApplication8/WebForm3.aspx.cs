using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm3 : System.Web.UI.Page
    {

        String[] str1 = { "project", "add project", "manage project", "lock/unlock", "project list" };

        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add(str1[0]);
            DropDownList1.Items.Add(str1[1]);
            DropDownList1.Items.Add(str1[2]);
            DropDownList1.Items.Add(str1[3]);
            DropDownList1.Items.Add(str1[4]);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DropDownList1.Items.FindByText("add project").Selected == true)
                Server.Transfer("add_project.aspx");
            else if (DropDownList1.Items.FindByText("manage project").Selected == true)
                Response.Redirect("http://onedio.com");

        }
    }
}