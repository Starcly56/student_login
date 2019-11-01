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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*string q = "select * from student where email='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                Database db = new Database(q);
                DataTable dt = db.GetData();*/
                StudentService ss = new StudentService();
                bool p=ss.CheckUsernameAndPassword(txtusername.Text,txtpassword.Text);

                if (p)
                {
                    Form1 f = new Form1();
                    f.Show();
                }
                else if (txtusername.Text == "admin" && txtpassword.Text == "admin")
                {
                    Form1 f = new Form1();
                    f.Show();
                } 
                else
                {
                    MessageBox.Show("Username or Password incorrect");
                }
                
                txtusername.Text = " ";
                txtpassword.Text = " ";
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
