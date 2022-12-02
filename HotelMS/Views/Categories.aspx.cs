using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelMS.Views
{
    public partial class Categories : System.Web.UI.Page
    {
        Model.function con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Model.function();
            showcategories();
            logeduser.InnerText = Session["username"] as string;
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            
        }

        private void showcategories() {

            string Query = "select catid as ID, catname as category,remarks from category ";
            Catgv.DataSource = con.GetData(Query);
            Catgv.DataBind();
        
        }
     
        protected void savebutton_Click(object sender, EventArgs e)
        {


               try 
            	{
                    string catname = cattb.Value;
                    string rem = remarktb.Value;
                    string Query = "insert into category values ('{0}','{1}')";
                    Query = string.Format(Query, catname, rem);
                    con.setData(Query);
                    showcategories();
                    errmsg.InnerText = "Category Added!!!";



		
                    	}
     
             
	        catch (Exception ex)
               {


                   errmsg.InnerText = ex.ToString();


               }




        }
        int key = 0;

        protected void Catgv_SelectedIndexChanged(object sender, EventArgs e)
        {
            key = Convert.ToInt32(Catgv.SelectedRow.Cells[1].Text);
            cattb.Value = Catgv.SelectedRow.Cells[2].Text;
            remarktb.Value = Catgv.SelectedRow.Cells[3].Text;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            try
            {
                string catname = cattb.Value;
                string rem = remarktb.Value;
                string Query = "update  category set catname = '{0}',remarks ='{1}' where catId = {2}";
                Query = string.Format(Query, catname, rem,Catgv.SelectedRow.Cells[1].Text);
                con.setData(Query);
                showcategories();
                errmsg.InnerText = "Category Updated!!!";




            }


            catch (Exception ex)
            {


                errmsg.InnerText = ex.ToString();


            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                string catname = cattb.Value;
                string rem = remarktb.Value;
                string Query = "delete from  category  where catId = {0}";
                Query = string.Format(Query, Catgv.SelectedRow.Cells[1].Text);
                con.setData(Query);
                showcategories();
                errmsg.InnerText = "Category deleted!!!";




            }


            catch (Exception ex)
            {


                errmsg.InnerText = ex.ToString();


            }
        }
	

    }
}