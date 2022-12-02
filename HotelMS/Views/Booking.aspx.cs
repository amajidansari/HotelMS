using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelMS.Views
{
    public partial class Booking : System.Web.UI.Page



    {

        Model.function con;

        protected void Page_Load(object sender, EventArgs e)
        {

            con = new Model.function();
            showrooms();
            showBooking();  
            Session["username"] = "";
            Session["Uid"] = "";
        }

        private void showrooms()
        {

            string Query = "select * from Roomtbl where status = 'Available' ";
            Roomsgv.DataSource = con.GetData(Query);
            Roomsgv.DataBind();

           
        }
        private void showBooking()
        {

            string Query = "select * from Bookingtbl ";
            bookinggv.DataSource = con.GetData(Query);
            bookinggv.DataBind();


        }


        int key = 0;
        int days = 1;
        protected void Roomsgv_SelectedIndexChanged(object sender, EventArgs e)
        {
            key = Convert.ToInt32(Roomsgv.SelectedRow.Cells[1].Text);
            Roomtb.Value = Roomsgv.SelectedRow.Cells[2].Text;
            int cost = days * Convert.ToInt32(Roomsgv.SelectedRow.Cells[5].Text);

            amountb.Value = cost.ToString();
            
        }
        
        
        private void updateroom() {

            try
            {

                string st = "Booked";
                string Query = "update  Roomtbl set  Status = '{0}' where RId = '{1}'";
                Query = string.Format(Query, st, Roomsgv.SelectedRow.Cells[1].Text);
                con.setData(Query);
                showrooms();
                //errmsg.InnerText = "Room Updated!!!";

                
            }


            catch (Exception ex)
            {



                errmsg.InnerText = ex.Message;

            }
        
        
        }

        int tcost;
        private void getcost() {

            DateTime Din = Convert.ToDateTime(datetb.Value);
            DateTime Dout = Convert.ToDateTime(dateoutb.Value);
            TimeSpan value = Dout.Subtract(Din);
            tcost = Convert.ToInt32(value.ToString().Substring(0, 2)) * Convert.ToInt32(Roomsgv.SelectedRow.Cells[5].Text);
            amountb.Value = tcost.ToString(); 
        
        }

        protected void bookbtn_Click(object sender, EventArgs e)
        {
         try
          {
               string Rid = Roomsgv.SelectedRow.Cells[1].Text;
               string Bdate = System.DateTime.Today.Date.ToString();
               string Indate = datetb.Value;

               string dateout = dateoutb.Value;
               string Agent = "501";
                   //Session["Uid"] as string;

               
                getcost();
                int amount = Convert.ToInt32(amountb.Value.ToString());
                string Query = "insert into Bookingtbl(BDate,BRoom,Agent,Datein,dateout,Amount) values ('{0}','{1}','{2}','{3}','{4}','{5}')";
                Query = string.Format(Query, Bdate, Rid, Agent, Indate, dateout, amount);
                con.setData(Query);
                updateroom();
                showrooms();
                errmsg.InnerText = "Room Booked!!!";

                datetb.Value = "";
                Roomtb.Value = "";
                dateoutb.Value = "";
                amountb.Value = "";




           }


       catch (Exception ex)
       {


            errmsg.InnerText = ex.Message;

          }
        }

    }
}