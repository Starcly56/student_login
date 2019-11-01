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
    public partial class Batch : Form
    {
        public Batch()
        {
            InitializeComponent();
        }
        
        private void Batch_Load(object sender, EventArgs e)//when form loads then event is fired so table is shown immediately
        {
            string q = "select * from Batch";
            Database db = new Database(q);
            db.GetData();
            DataTable dt = db.GetData();//returns datatable
            
            dataGridView1.DataSource = dt;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower() == "delete")
                {
                    if (MessageBox.Show(" Are you ","Delete",MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        string q = "delete from Batch where id =" + id;
                        Database db = new Database(q);
                        db.ExecuteNonQuery();
                    }
                }
                else
                {
                    New_Batch nb = new New_Batch(id);
                    ///nb.myID = id;
                    nb.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoadBatch();
        }
        private void LoadBatch()
        {
            try
            {
                string q = "select * from Batch";
                Database db = new Database(q);
                db.GetData();
                DataTable dt = db.GetData();//returns datatable
                dataGridView1.DataSource = dt;

            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
