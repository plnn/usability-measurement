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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(
            "Server=localhost;Database=Project;Integrated Security=true"/*ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString*/);
       
    //SqlCommand cmd = new SqlCommand("select user_username, user_password FROM users WHERE user_username =@username and user_password=@password", con);
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Redirect("http://google.com.tr");
        }


        //BURADA VERITABANINDA O HESAPTAN KİMSE VAR MI BAKILACAK
        //SIGN IN
        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String str  = "INSERT INTO [dbo].[user](email, passwrd) values "+"('"+TextBox1.Text+"','"+TextBox2.Text+"')";
            Response.Write("<script>alert('sdfdsfdsf')</script>");

            cmd.Connection = con;
            cmd.CommandText = str;
            cmd.CommandType = CommandType.Text;
            
            cmd.ExecuteNonQuery();
            
            
            con.Close();
            //Response.Write("<script>alert('Bu bir denemedir')</script>");
        }


        //login
        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            //String str = "select count(*) from [dbo].[user] where " + "email = " + TextBox3.Text + " and passwrd = " + TextBox4.Text+"";
            String str = "select count(*) from [dbo].[user] where email=@email and passwrd=@passwrd";
            cmd.Connection = con;
            cmd.CommandText = str;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@email", TextBox3.Text.ToString());   //for username 
            cmd.Parameters.AddWithValue("@Passwrd", TextBox4.Text.ToString());  //for password

            //cmd.ExecuteNonQuery();
            int result = (int)cmd.ExecuteScalar();
            if (result > 0)
            {
                Response.Write("<script>alert('Bu bir denemedir')</script>");
                //Response.Redirect("http://www.google.com.tr");
                Server.Transfer("home.aspx", true);
            }
            else
            {
                Response.Write("<script>alert('hatali denemedir')</script>");

                con.Close();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string strURL = "resim/Adsız.png";
                WebClient req = new WebClient();
                HttpResponse response = HttpContext.Current.Response;
                response.Clear();
                response.ClearContent();
                response.ClearHeaders();
                response.Buffer = true;
                response.AddHeader("Content-Disposition", "attachment;filename=\"" + Server.MapPath(strURL) + "\"");
                byte[] data = req.DownloadData(Server.MapPath(strURL));
                response.BinaryWrite(data);
                response.End();
            }
            catch (Exception ex)
            {
            }
        }

        
    }
}