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
    public partial class UploadTest : Form
    {
        public UploadTest()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                DialogResult dr= ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    File.Copy(ofd.FileName, AppContext.BaseDirectory + "\\" + ofd.SafeFileName);
                    MessageBox.Show("Upload success");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string path = AppContext.BaseDirectory;//Environment.CurrentDirectory ;
            DirectoryInfo di = new DirectoryInfo(path);
            ///di.GetFiles("*.jpg");
            FileInfo[] files = di.GetFiles("*.jpg");
            dataGridView1.DataSource = files;
            int w = 110;
            int c = 1;  

            foreach(FileInfo fi in files)
            {
                PictureBox pb = new PictureBox();
                pb.ImageLocation = fi.FullName;
                pb.Height = 100;
                pb.Width = 100;
                pb.Location = new Point(10+w*c, 0);
                panel1.Controls.Add(pb);
                Random r = new Random();
                c++;
            }
            
            /*
             static class object no need static member static method 
             abstract class abstraact method or non abstract method 
             virutal class override method
             over ride  function all signature same but difference behaviour 
             in run time ,run time ma open huncha operate
             overload function name same but different parameters
             function static cha vane message box show huncha whenever 
             no need to create objecct and initialize the value 
             virtual cha vane override nagarda ni huncha tara 
             abstract cha vane overrid(object) of the abstract class 
             can implemented by non abstract child class 
             abstract and interface are similar in some way 
             it contains only function declaration 
             its members are abstract and public by default
             cannot create instance of class 
             interface keyword is used 
             sealed class= it blocks inheritance
             paper prototype 
             paper and pencil
             easy and efficient approach 
             list task of system
             wizard of OZ simulation--
             developers minimize details for the system

             */
        }
        /*private void Load()
        {
            string path = AppContext.BaseDirectory;//Environment.CurrentDirectory ;
            DirectoryInfo di = new DirectoryInfo(path);
            ///di.GetFiles("*.jpg");
            FileInfo[] files = di.GetFiles("*.jpg");
            dataGridView1.DataSource = files;
            int w = 110;
            int c = 1;

            foreach (FileInfo fi in files)
            {
                PictureBox pb = new PictureBox();
                pb.ImageLocation = fi.FullName;
                pb.Height = 100;
                pb.Width = 100;
                pb.Location = new Point(10 + w * c, 0);
                panel1.Controls.Add(pb);
                Random r = new Random();
                c++;
            }
        }*/
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string deletea=dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower();
            if (deletea=="delete")
            {
                string patha = dataGridView1.Rows[e.RowIndex].Cells["FullName"].Value.ToString().ToLower();
                File.Delete(patha);
                MessageBox.Show("Deleted successfully");
                panel1.Controls.Clear();
            }
        }
    }
}
