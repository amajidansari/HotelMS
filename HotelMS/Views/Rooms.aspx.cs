using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelMS.Views
{
    public partial class Rooms : System.Web.UI.Page
    {
        Model.function con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Model.function();

            showrooms();
            getcategories();

        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void showrooms()
        {

            string Query = "select * from Roomtbl ";
            Roomsgv.DataSource = con.GetData(Query);
            Roomsgv.DataBind();

        }
        private void getcategories() {

            string Query = "select * from category";
            catcb.DataTextField = con.GetData(Query).Columns["catname"].ToString();

            catcb.DataValueField = con.GetData(Query).Columns["catId"].ToString();
            catcb.DataSource = con.GetData(Query);
            catcb.DataBind();


        }

        protected void savebutton_Click(object sender, EventArgs e)
        {

            try
            {
                string Rname = Rnametb.Value;
                string Rcat = catcb.SelectedValue.ToString();
                string Rloc = locationtb.Value;
                string cost = roomcosttb.Value;
                string rem = remarks.Value;
                string status = "Available";


                string Query = "insert into Roomtbl values ('{0}','{1}','{2}','{3}','{4}','{5}')";
                Query = string.Format(Query, Rname,Rcat,Rloc,cost,rem,status);
                con.setData(Query);
                showrooms();
                errmsg.InnerText = "Room Added!!!";

                Rnametb.Value = "";
                catcb.SelectedIndex = -1;
                locationtb.Value ="";
                roomcosttb.Value = "";
                remarks.Value = "";
                



            }


            catch (Exception ex)
            {


                errmsg.InnerText = ex.Message;

            }
        }
        int key = 0;
        protected void Roomsgv_SelectedIndexChanged(object sender, EventArgs e)
        {
            key = Convert.ToInt32(Roomsgv.SelectedRow.Cells[1].Text);
            Rnametb.Value = Roomsgv.SelectedRow.Cells[2].Text;
            catcb.SelectedValue = Roomsgv.SelectedRow.Cells[3].Text;
            locationtb.Value = Roomsgv.SelectedRow.Cells[4].Text;
            roomcosttb.Value = Roomsgv.SelectedRow.Cells[5].Text;
            remarks.Value = Roomsgv.SelectedRow.Cells[6].Text;
            status.SelectedValue = Roomsgv.SelectedRow.Cells[7].Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            try
            {
                string Rname = Rnametb.Value;
                string Rcat = catcb.SelectedValue.ToString();
                string Rloc = locationtb.Value;
                string cost = roomcosttb.Value;
                string rem = remarks.Value;
                string statuss = status.SelectedValue.ToString();


                string Query = "update  Roomtbl set Rname ='{0}',RCategory = '{1}',RLocation = '{2}',RCost = '{3}',Rremark = '{4}', Status = '{5}' where RId = '{6}'";
                Query = string.Format(Query, Rname, Rcat, Rloc, cost, rem, statuss,Roomsgv.SelectedRow.Cells[1].Text);
                con.setData(Query);
                showrooms();
                errmsg.InnerText = "Room Updated!!!";

                Rnametb.Value = "";
                catcb.SelectedIndex = -1;
                locationtb.Value = "";
                roomcosttb.Value = "";
                remarks.Value = "";




            }


            catch (Exception ex)
            {



                errmsg.InnerText = ex.Message;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             try
            {
                string Rname = Rnametb.Value;
                string Rcat = catcb.SelectedValue.ToString();
                string Rloc = locationtb.Value;
                string cost = roomcosttb.Value;
                string rem = remarks.Value;
                string statuss = status.SelectedValue.ToString();
               
                 
                 
                 string Query = "delete from  Roomtbl  where RId = {0}";
                Query = string.Format(Query, Roomsgv.SelectedRow.Cells[1].Text);
                con.setData(Query);
                showrooms();
                errmsg.InnerText = "Rooms deleted!!!";


                Rnametb.Value = "";
                catcb.SelectedIndex = -1;
                locationtb.Value = "";
                roomcosttb.Value = "";
                remarks.Value = "";
                

            }


            catch (Exception ex)
            {


                errmsg.InnerText = ex.Message;


            }
        }
        
    }
}