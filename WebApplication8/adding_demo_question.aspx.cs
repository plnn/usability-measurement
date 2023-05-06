using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Net;
namespace WebApplication8
{
    public partial class adding_demo_question : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(
            "Server=localhost;Database=Project;Integrated Security=true"/*ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString*/);
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            //DateTime theDate = DateTime.Now;
            //string sqlFormattedDate = theDate.Date.ToString("yyyy-MM-dd");

            String str = "INSERT INTO [dbo].[demograph](question,answer,type) values " + "('" + TextBox1.Text + "','" + TextBox2.Text + "','" + "radio" + "')";
          //  Response.Write("<script>alert('sdfdsfdsf')</script>");
            MessageBox.Show("You added successfuly");
            cmd.Connection = con;
            cmd.CommandText = str;
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();


            con.Close();
        }
    }
}