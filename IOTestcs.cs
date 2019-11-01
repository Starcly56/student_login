using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace login_of__student
{
    public partial class IOTestcs : Form
    {
        public IOTestcs()
        {
            InitializeComponent();
        }//static then we shouldnot create object 
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtFolderName.Text == "")
            {
                MessageBox.Show("BHOSIDKEY FOLDER KA NAME DAAL");//this is also static method 
            }
            else
            {
                try
                {
                    string path = Environment.CurrentDirectory;
                    if (!Directory.Exists(path+"\\" + txtFolderName.Text))
                    {
                        Directory.CreateDirectory(path + "\\" + txtFolderName.Text);
                        
                    }
                    MessageBox.Show("Folder added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(path);
            DirectoryInfo[] arr = di.GetDirectories();
            dataGridView1.DataSource = arr;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//to lower all small
            string delete = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower();
            if ( delete== "delete")
            {
                string path = dataGridView1.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                Directory.Delete(path);
                /* DirectoryInfo di = new DirectoryInfo(path);
                 di.Delete();*/
                MessageBox.Show("Deleted successfully");
                
            }
            else
            {
                IOTestcs io = new IOTestcs();
                io.Show();

            }
        }
    }
}
