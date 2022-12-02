using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.SessionState;

namespace HotelMS.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Model.function();
            Session["username"] = "";
             Session["Uid"] = "";
        }
        Model.function con;
        protected void Logi_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Views/Rooms.aspx");

            if (admincb.Checked)
            {
                if (email.Value == "Admin" && password.Value == "Password") 

                {
                    Session["username"] = "Admin";

                    Response.Redirect("Rooms.aspx");

                }

                else
                {
                    errormsg.InnerText = "Invalid details";
                }


            }

            else
            {

                
                string Query = "select top 1 UId,UName,Upassword from USertbl where UName =  '{0}'and Upassword = '{1}'";

                Query = string.Format(Query, email.Value, password.Value);
                DataTable dt = con.GetData(Query);
                if (dt.Rows.Count==0)
                {
                    errormsg.InnerText = "Invalid details";
                    
                }
                else
                {
                    //errormsg.InnerText = dt.Rows[0][0].ToString();
                   
                    Session["username"] = dt.Rows[0][1].ToString();
                    Session["Uid"] = Convert.ToInt32(dt.Rows[0][0].ToString());

        
                    Response.Redirect("Booking.aspx");
                }
            
            
            }






        }
    }
}