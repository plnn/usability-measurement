using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

using System.Net; 
namespace WebApplication8
{
    public partial class editProject : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(
            "Server=localhost;Database=Project;Integrated Security=true"/*ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString*/);
  
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DateTime theDate = DateTime.Now;
            string sqlFormattedDate = theDate.Date.ToString("yyyy-MM-dd");
    
            String str = "UPDATE [dbo].[proj_uet](name,url,date) values " + "('" + TextBox1.Text + "','" + sqlFormattedDate + "','" + TextBox2.Text + "')";
         
        }
    }
}