using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace login_of__student
{
    public class StudentService 
    {
        public DataTable GetAllStudents()
        {
            try
            {
                string select = "select * from Student";
                Database db = new Database(select);
                return db.GetData();
                //return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            //messagebox only in form 
        }
        public bool InsertStudent(Student s)
        {
            try
            {
                string q = "insert into student values('" + s.Name + "','" + s.Email + "','"+s.Password+"','" + s.Gender + "'," + s.BatchId + ")";
                Database db = new Database(q);
                db.ExecuteNonQuery();
                return true;
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateStudents(Student s)
        {
            try
            {
                string q = "update Student set name='" + s.Name + "',email='" + s.Email + "',[Batch ID]=" + s.BatchId + ",Password='" + s.Password + "',Gender='" + s.Gender + "' where id=" + s.Id;
                Database db = new Database(q);
                db.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(Student s)
        {
            try
            {
                string q = "delete from student where id=" + s.Id;
                Database db = new Database(q);
                db.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool CheckUsernameAndPassword(string username,string password)
        {
            try
            {
                string q = "select * from student where email='" + username + "' and password='" + password + "'";
                Database db = new Database(q);
                DataTable dt = db.GetData();
                if (dt.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
