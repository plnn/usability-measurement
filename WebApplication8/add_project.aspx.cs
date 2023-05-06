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
    public partial class add_project : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(
            "Server=localhost;Database=Project;Integrated Security=true"/*ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString*/);
      
        
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // Server.Transfer("UET_click.aspx");
            Server.Transfer("WebForm4.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            DateTime theDate = DateTime.Now;
            string sqlFormattedDate = theDate.Date.ToString("yyyy-MM-dd");

            String str = "INSERT INTO [dbo].[proj_uet](name,url,date) values " + "('" + TextBox1.Text + "','" + TextBox3.Text + "','" + sqlFormattedDate + "')";
            Response.Write("<script>alert('sdfdsfdsf')</script>");

            cmd.Connection = con;
            cmd.CommandText = str;
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();
            

            con.Close();
        }
    }
}