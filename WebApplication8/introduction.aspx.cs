using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;



namespace WebApplication8
{
    public partial class introduction : System.Web.UI.Page
    {
        SqlDataAdapter myAdapter = new SqlDataAdapter();
        DataSet myDataSet = new DataSet();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(
            "Server=localhost;Database=Project;Integrated Security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
             


           

            con.Open();
            String str = "select * from [dbo].[user]";
            myAdapter.SelectCommand = cmd;

            cmd.Connection = con;
            cmd.CommandText = str;
            cmd.CommandType = CommandType.Text;
            myAdapter.Fill(myDataSet, "[dbo].[user]");

          //  cmd.ExecuteNonQuery();


            con.Close();
            GridView1.DataSource = myDataSet;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("home.aspx",true);
        }
    }
}