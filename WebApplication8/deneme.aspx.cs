using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class deneme : System.Web.UI.Page
    {
        string str2;
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Session["val2"].ToString();
            
        }
    }
}