using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_of__student
{
    public partial class New_Student : Form
    {
        int id=0;
        public New_Student()
        {
            InitializeComponent();
        }
        public New_Student(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void New_Student_Load(object sender, EventArgs e)
        {
            try
            {//loading the batch from the batch
                Database db = new Database("select * from Batch");
                DataTable dt= db.GetData();
                comboBatch.DisplayMember = "Name";
                comboBatch.ValueMember = "Id";
                comboBatch.DataSource = dt;
                if(id>0)
                {
                    string select_student = "select * from student where id ="+id;
                    db = new Database(select_student);
                    DataTable dts = db.GetData();
                    if(dts.Rows.Count>0)
                    {
                        textname.Text = dts.Rows[0]["Name"].ToString();
                        textemail.Text = dts.Rows[0]["Email"].ToString();
                        textpassword.Text = dts.Rows[0]["Password"].ToString();
                        textconfirm.Text = dts.Rows[0]["Password"].ToString();
                        if (dts.Rows[0]["Gender"].ToString()=="Male")
                        {
                            radiomale.Checked = true;
                        }
                        else
                        {
                            radiofemale.Checked = true;
                        }
                        comboBatch.SelectedValue = dts.Rows[0]["Batch ID"];
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = textemail.Text;
                string password = textpassword.Text;
                string cpassword = textconfirm.Text;
                //if (password == cpassword)
                Helper h = new Helper();
                
                if (h.CheckPassword(password, cpassword))
                {
                    if (h.CheckEmail(email))
                    //if (email.Contains("@"))
                    {
                        /*
                        string gender = "M";
                        if (radiomale.Checked)
                        {
                            gender = "M";
                        }
                        else
                        {
                            gender = "F";
                        }*/
                        string gender = radiomale.Checked ? "Male" : "Female";

                        int bid = Convert.ToInt32(comboBatch.SelectedValue);
                        /* string q = "insert into student values('" + textname.Text + "','" + textemail.Text + "','" + textpassword.Text + "','" + gender + "'," + bid + ")";
                         if (id > 0)
                         {
                             q = "update Student set name='" + textname.Text + "',email='" + textemail.Text + "',[Batch ID]=" + bid + ",Password='" + textpassword.Text + "',Gender='" + gender + "' where id=" + id;
                         }             
                        Database db = new Database(q);
                        db.ExecuteNonQuery();*/
                        Student s = new Student();
                        s.Name = textname.Text;
                        s.Email = textemail.Text;
                        s.Password = textpassword.Text;
                        s.BatchId = bid;
                        s.Gender = gender;
                        StudentService ss = new StudentService();
                        if (id > 0)
                        {
                            s.Id = id;
                            ss.UpdateStudents(s);
                        }
                        else
                        {
                            ss.InsertStudent(s);
                            /*if (textpassword.Text != textconfirm.Text)
                             {
                                 MessageBox.Show("Password doesnot match");
                             }
                             else
                             {
                                 MessageBox.Show("Saved successfully");
                             }*/
                        }
                        MessageBox.Show("saved successfully");
                   }
                   else
                    {
                        MessageBox.Show("email is invalid");
                    }
                }
                else
                {
                    MessageBox.Show("Password doesnot match");
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
