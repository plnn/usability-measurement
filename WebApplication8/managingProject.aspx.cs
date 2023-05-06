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
    public partial class WebForm2 : System.Web.UI.Page
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
            con.Open();
            DateTime theDate = DateTime.Now;
            string sqlFormattedDate = theDate.Date.ToString("yyyy-MM-dd");

            String str = "UPDATE [dbo].[proj_uet] set name='" + TextBox1.Text+"' , url ='" +TextBox2.Text +"'"+" where name='"+DropDownList1.SelectedItem.ToString()+"'";



       //    str = "update Example set Info ='" + TextBox1 + "', Text ='" + textBox3.Text + "' where ID ='" + textBox1.Text + "'";

            //  + " where name= '" + DropDownList1.SelectedItem.ToString()+"'";
            //String str = "INSERT INTO [dbo].[proj_uet](name,url,date) values " + "('" + TextBox1.Text + "','" + TextBox2.Text + "','" + sqlFormattedDate + "')";
           
            cmd.Connection = con;
            cmd.CommandText = str;
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();


            con.Close();
          

         
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("UET_click.aspx",true);
        }

        
    

      

        

       

    }
}