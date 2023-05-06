using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          DateTime today = DateTime.Today;
           Calendar1.TodaysDate = today;
              Calendar1.SelectedDate = Calendar1.TodaysDate;
            //   BindCalendar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("introduction.aspx",true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("UET_click.aspx",true);
        }

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {

        }
        private void BindCalendar()
        {
           
            Calendar1.SelectedDate = DateTime.Now;
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
    }
}