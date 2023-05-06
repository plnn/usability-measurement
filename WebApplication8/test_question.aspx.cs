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
    public partial class test_question : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(
            "Server=localhost;Database=Project;Integrated Security=true");


        public void strSplit(string str,string[] resStr){
            int i=0;
            int j=0;
            string temp="";
          
            for (; i < str.Length; ++i)
            {
                if (str[i] != '|' )
                    temp += str[i];
                else if(str[i]=='|')
                {
                    resStr[j] = temp;
                    temp = "";
                    ++j;
                }
            }
           

        }

        int numOfS(string str)
        {
           
            int res=0;
            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; ++i)
            {
                if (ch[i] == '|' || ch[i] == '\0')
                {
                    ++res;

                }
            }
         
            
            return res ;
        }
        

        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Session["val2"].ToString();
            string myStr = TextBox1.Text;
            con.Open();
            cmd = new SqlCommand("Select question,answer from [dbo].[demograph] where id in "+"( select numOfCol from [dbo].[assign_demo] where project = '"+myStr+"')", con);
          //  cmd = new SqlCommand("select numOfCol from [dbo].[assign_demo] where project = '"+myStr+"'",con);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            Panel[] panarr = new Panel[20];

            int p = 0;
            for (p = 0; p < 15; ++p)
                panarr[p] = new Panel();
            p = 0;

                while (dr.Read())
                {
                    ++p;
                    //Panel pan = new Panel();

                    Label l = new Label();

                    l.Text = dr["question"].ToString();
                    l.ForeColor = System.Drawing.Color.Lavender;
                    l.Font.Name = "Arial";
                    l.Font.Size = 14;
                    //pan.Controls.Add(l);
                    panarr[p].Controls.Add(new LiteralControl("<br />")); 

                    panarr[p].Controls.Add(l);
                    //TableCell tc = new TableCell();
                    this.Controls.Add(panarr[p]);
                    string str = dr["answer"].ToString();

                    int res = numOfS(str);
                   // Panel pan2 = new Panel();
                    string[] s = new string[res];
                    strSplit(str, s);
                    int i = 0;
                    while (i < s.Length)
                    {
                        panarr[p].Controls.Add(new LiteralControl("<br />")); 

                        RadioButton rb = new RadioButton();
                        rb.Text = s[i];
                        rb.BackColor = System.Drawing.Color.White;
                        rb.Font.Size = 12;
                        rb.Font.Name = "Georgia";
                        rb.ID = "rb" + Convert.ToString(i);
                        panarr[p].Controls.Add(rb);
                        // pan2.Controls.Add(rb);
                        // this.Controls.Add(pan);

                        /* this.Controls.Add(rb);*/
                        panarr[p].Controls.Add(new LiteralControl("<br />")); 

                        form1.Controls.Add(panarr[p]);

                        ++i;
                    }



                }

        }
    }
}