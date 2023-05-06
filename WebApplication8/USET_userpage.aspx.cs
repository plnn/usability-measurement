using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
namespace WebApplication8
{
    public partial class USET_userpage : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            
         //   if(TextBox1.Text=="" && DropDownList1.Text=="")
            
            Session.Add("val",TextBox1.Text);
            Session.Add("val2",TextBox2.Text);
            //Response.Redirect("deneme.aspx");
            RadioButton rb = new RadioButton();
            rb.Text = "cfdfg";
            // str2 = DropDownList1.Text;
            Response.Redirect("TestPart.aspx");
        }
     
    }
}