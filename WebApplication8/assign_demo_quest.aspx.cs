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
    public partial class assign_demo_quest : System.Web.UI.Page
    {
        static int st = 0;

        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(
            "Server=localhost;Database=Project;Integrated Security=true"/*ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString*/);
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
           
           con.Open();
            cmd = new SqlCommand("Select * from [dbo].[demograph]", con);
            dr = cmd.ExecuteReader();
             GridView1.DataSource = dr;
            // GridView1.DataBind();
             if (!Page.IsPostBack)
             {
                 // GridView1.DataSourceID = "yourDatasourceID";
                 GridView1.DataBind();
             }
            dr.Close();
            con.Close();


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

        

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string data = "";
            con.Open();
           foreach (GridViewRow row in GridView1.Rows)
           {
               if (row.RowType == DataControlRowType.DataRow)
                {
                  
                    CheckBox chkRow = (row.Cells[0].FindControl("CheckBox1") as CheckBox);
                    if (chkRow.Checked==true)
                    {

                      /*  string storid = row.Cells[1].Text;
                        string storname = row.Cells[2].Text;
                        string state = row.Cells[3].Text;*/
                        int val = Int32.Parse(row.Cells[1].Text);
                        String str = "INSERT INTO [dbo].[assign_demo](project,email,numOfCol) values " + "('" +DropDownList1.Text + "','" + row.Cells[5].Text + 
                                                        "','" +val + "')";
                       // data = data + storid + " ,  " + storname + " , " + state + "<br>";
                        cmd.Connection = con;
                        cmd.CommandText = str;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        

 
                    }
                }
            }
           //Label1.Text = data;
           con.Close();

          
          
           
            
        }

       

       
    }
}