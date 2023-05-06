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
    public partial class checklist : System.Web.UI.Page
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
            cmd = new SqlCommand("Select count(id) from [dbo].[assign_demo] where project= '"+DropDownList1.Text+"'", con);
            int result =(int) cmd.ExecuteScalar();
            MessageBox.Show(result.ToString());
            if (result < 0 || result==0)
            {


                Label1.Visible = true;
                Label1.Text = "there is no demographic  for add ";
              
                LinkButton1.Visible = true;

            }

            cmd = new SqlCommand("Select count(*) from [dbo].[test_user] where project= '" + DropDownList1.Text + "'", con);
        
        result =(int) cmd.ExecuteScalar();
        MessageBox.Show(DropDownList1.Text);
            if (result < 0 || result==0)
            {
                Label2.Visible = true;
                Label2.Text = "there is no user for test for add";

                LinkButton2.Visible = true;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            st = 0;

            Response.Redirect("WebForm4.aspx",true);
        }

       
    }
}