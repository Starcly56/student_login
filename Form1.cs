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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Student ns = new New_Student(0);
            ns.Show();
        }

        private void DisplayStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Displaystudent ds = new Displaystudent();
            ds.Show();
        }

        private void NewBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Batch nb = new New_Batch();
            nb.Show();
        }

        private void DisplayBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Batch b = new Batch();
            b.Show();
        }

        private void Buttonexit_Click(object sender, EventArgs e)
        {
            /* Login l = new Login();
             l.Show();*/
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseClick += Form1_MouseClick;
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();//creating a random object
            this.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            
        }

        private void FileTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileTest ft = new FileTest();
            ft.Show();
        }

        private void UploadTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadTest ut = new UploadTest();
            ut.Show();
        }

        private void IOTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IOTestcs it = new IOTestcs();
            it.Show();
        }

        private void PolymerphismToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Polymerphism p = new Polymerphism();
            p.Show();
        }
    }
}
