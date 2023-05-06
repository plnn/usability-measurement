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
    public partial class add_test_user : System.Web.UI.Page
    {
        static int st = 0;
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(
            "Server=localhost;Database=Project;Integrated Security=true"/*ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString*/);
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (st == 0)
            {
                DropDownList1.Items.Add("select");

                con.Open();
                cmd = new SqlCommand("Select name from [dbo].[proj_uet]", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DropDownList1.Items.Add(dr[0].ToString());
                }
                dr.Close();
                con.Close();
                st = 1;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            //DateTime theDate = DateTime.Now;
            //string sqlFormattedDate = theDate.Date.ToString("yyyy-MM-dd");

            String str = "INSERT INTO [dbo].[test_user](user_t,mail,project) values " + "('" + TextBox1.Text + "','" + TextBox2.Text + "','" +DropDownList1.Text + "')";
          //  Response.Write("<script>alert('sdfdsfdsf')</script>");

            cmd.Connection = con;
            cmd.CommandText = str;
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();


            con.Close();
        }
    }
}