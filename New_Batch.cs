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
    public partial class New_Batch : Form
    {
        ///through constructor or through properties
        //public int myID;
        int id;
        public New_Batch()//yesma banauda ni huncha
        {
            InitializeComponent();
        }

       public New_Batch (int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string qq = "insert into Batch values ('" + txtBatch.Text + "')";//single coat for dynamic
                if (id > 0)
                {
                    qq = "update Batch set name='" + txtBatch.Text + "'where id="+id;
                }
                Database db = new Database(qq);
                db.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void New_Batch_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                try
                {
                    Database db = new Database("select * from Batch where ID=" + id);
                    DataTable dt = db.GetData();
                    txtBatch.Text = dt.Rows[0]["Name"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}