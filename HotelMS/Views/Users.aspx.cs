using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelMS.Views
{
    public partial class Users : System.Web.UI.Page
    {
        Model.function con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Model.function();
            Showuser();
        }
        private void Showuser() {

            string Query = "select UId,UName,UPhone,UGen,UAdd from USertbl";
            usergv.DataSource = con.GetData(Query);
            usergv.DataBind();

        
        
        
        }



        protected void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string Uname = usernametb.Value;
                string Uphone = phonetb.Value;

                string Ugen = catcb.SelectedValue.ToString();
                string UAdd = addreetb.Value;
                string Upass = passwordtb.Value;
                
                string Query = "insert into USertbl values ('{0}','{1}','{2}','{3}','{4}')";
                Query = string.Format(Query, Uname, Uphone, Ugen, UAdd, Upass);
                con.setData(Query);
                Showuser();
                errmsg.InnerText = "User Added!!!";

                usernametb.Value = "";
                catcb.SelectedIndex = -1;
                phonetb.Value = "";
                addreetb.Value = "";
                passwordtb.Value = "";




            }


            catch (Exception ex)
            {


                errmsg.InnerText = ex.Message;

            }
        }
        int key = 0;
        protected void usergv_SelectedIndexChanged(object sender, EventArgs e)
        {
            key = Convert.ToInt32(usergv.SelectedRow.Cells[1].Text);
            usernametb.Value = usergv.SelectedRow.Cells[2].Text;
            phonetb.Value = usergv.SelectedRow.Cells[3].Text;
       
            catcb.SelectedValue = usergv.SelectedRow.Cells[4].Text;
            addreetb.Value = usergv.SelectedRow.Cells[5].Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Uname = usernametb.Value;
                string Uphone = phonetb.Value;

                string Ugen = catcb.SelectedValue.ToString();
                string UAdd = addreetb.Value;
                string Upass = passwordtb.Value;

                string Query = "update  USertbl set UName =  '{0}',UPhone = '{1}',UGen = '{2}',UAdd = '{3}',Upassword = '{4}' where UId = '{5}'";
                Query = string.Format(Query, Uname, Uphone, Ugen, UAdd, Upass,usergv.SelectedRow.Cells[1].Text);
                con.setData(Query);
                Showuser();
                errmsg.InnerText = "User Updated!!!";

                usernametb.Value = "";
                catcb.SelectedIndex = -1;
                phonetb.Value = "";
                addreetb.Value = "";
                passwordtb.Value = "";




            }


            catch (Exception ex)
            {


                errmsg.InnerText = ex.Message;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            string Query = "delete from  USertbl  where UId = {0}";
            Query = string.Format(Query, usergv.SelectedRow.Cells[1].Text);
            con.setData(Query);
            Showuser();
            errmsg.InnerText = "User deleted!!!";


            
                usernametb.Value = "";
                catcb.SelectedIndex = -1;
                phonetb.Value = "";
                addreetb.Value = "";
                passwordtb.Value = "";


        }
    }
}