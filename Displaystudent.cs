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
    public partial class Displaystudent : Form
    {
        public Displaystudent()
        {
            InitializeComponent();
        }
      

        private void Displaystudent_Load(object sender, EventArgs e)
        {
            //LoadStudent();
            StudentService ss = new StudentService();
            DataTable dt = ss.GetAllStudents();
            dataGridView.DataSource = dt;
        }
        

        
        private void LoadStudent()
        {
            try
            {
                string student = "select * from Student";
                Database database = new Database(student);
                DataTable data = database.GetData();//returns datatable
                dataGridView.DataSource = data;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }     
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower() == "delete")
                {
                    if (MessageBox.Show(" Are you sure? ", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        /*string p = "delete from student where id="+id;
                        Database db = new Database(p);
                        db.ExecuteNonQuery();*/
                        StudentService ss = new StudentService();
                        Student s = new Student();
                        s.Id = id;
                        ss.Delete(s);
                    }
                }
                else
                {
                    New_Student ns = new New_Student(id);
                    ns.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void Button_Click(object sender, EventArgs e)
        {
            LoadStudent();
        }
    }
}
