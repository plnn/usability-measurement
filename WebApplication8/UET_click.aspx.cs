using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class UET_click : System.Web.UI.Page
    {

        String[] str1 = {"project","add project","edit project","delete project","lock/unlock","project list"};

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
            else if (DropDownList1.Items.FindByText("edit project").Selected == true)
                Server.Transfer("managingProject.aspx",true);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("home.aspx",true);
        }
    }
}