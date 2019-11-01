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
    public partial class FileTest : Form
    {
        public FileTest()
        {
            InitializeComponent();
        }

        private void FileTest_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = ".txt";
                DialogResult dr = sfd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    sw.Write(textBox1.Text);
                    sw.Flush();
                    sw.Close();
                    MessageBox.Show("Saved Successfully");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(ofd.FileName);
                    string content = sr.ReadToEnd();
                    sr.Close();
                    textBox1.Text = content;
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
