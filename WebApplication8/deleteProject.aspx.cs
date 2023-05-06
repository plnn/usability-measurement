using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Net; 

namespace WebApplication8
{
    public partial class deleteProject : System.Web.UI.Page
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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Select * from [dbo].[proj_uet] where name='" + DropDownList1.SelectedItem.ToString() + "'", con);
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (msg == DialogResult.Yes)
            {
                Response.Redirect("http://onedio.com");
            }
            /*Button1.Attributes.Add("onclick",
       "return confirm('Are you sure you want to do this');");*/
            
           
        }
     
    }
}