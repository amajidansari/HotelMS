using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace HotelMS.Model
{
    public class function
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private string constr;
        private SqlDataAdapter sda;

        public int setData(string Query)
        {

            int cnt;
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }


            cmd.CommandText = Query;
            cnt = cmd.ExecuteNonQuery();
            con.Close();

            return cnt;
        }
        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, constr);

            sda.Fill(dt);
            return dt;
        }
        public function() {

            constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Documents\hotelasp.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(constr);
            cmd = new SqlCommand();
            cmd.Connection = con;




        
        
        }



    }
}