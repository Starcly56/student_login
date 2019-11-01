using System;
using System.Data;
using System.Data.SqlClient;

namespace login_of__student
{
    class Database
    {
        SqlConnection con;
        string query;
        public Database (string query)//constructor with parameter ,initialize 
        {
            con = new SqlConnection("data source=(local);Initial Catalog=Batch25A;Integrated Security=True");
            this.query = query;
        }
            /*sql connection connects the database source
            initial catlog defines database name always pass in the constructor
            function created for delete insert update
            always int
            command passed in constructor to define what does the parameter does*/
        public int ExecuteNonQuery()//insert,update,delete
        {

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                cmd.Connection.Open();
                return cmd.ExecuteNonQuery();//now data is executed
            }
            catch(Exception ex )
            {
                throw ex;
            }
            finally
            {
                if(cmd.Connection.State!=ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
        }
        public  DataTable GetData() //accessmodifier return   dataset-represent data in memory
        {
            try
            {    //sql command use than we need to open and close the database other than not
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                //collection of table so using dataset 
                DataSet ds = new DataSet();
                //bringing the datas from database to the memory
                da.Fill(ds);
                if (ds.Tables.Count>0)
                {
                    return ds.Tables[0];
                }
                else { return null; }
            }
            catch(Exception ex)
            {
                throw ex;
                //passing in the object only private variables via constructor
            }
        }
    }
}