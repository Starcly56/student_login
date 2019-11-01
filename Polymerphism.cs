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
    public partial class Polymerphism : Form
    {
        public Polymerphism()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Child c = new Child();
            Parent p = (Parent)c;
            string str = p.method1();
            //MessageBox.Show(str);
            string str2 = p.method2();
            MessageBox.Show(str+"\n"+str2);
            /*runtime ma call vayo override 
             compile time ma cha vane overload
             */
              
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Students s = new Students();
            Person p = (Person)s;
            MessageBox.Show(p.Play());
            //MessageBox.Show(s.Play());
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Ishape s= new Rectangle();
            s.X = 200;
            s.Y = 20;
            s.width = 300;
            s.height = 200;
            Graphics g = this.CreateGraphics();
            s.drawShape(g);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Ishape s = new Rectangle();
            s.X = 200;
            s.Y = 20;
            s.width = 200;
            s.height = 200;
            Graphics g = this.CreateGraphics();
            s.drawCircle(g);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Ishape s = new Rectangle();
            s.X = 300;
            s.Y = 20;
            s.width = 200;
            s.height = 200;
            s.sangle = 0;
            s.swangle = 360;
            Graphics g = this.CreateGraphics();
            s.drawCCircle(g);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Sealed_test st = new Sealed_test();
            string text= st.showTest();
            MessageBox.Show(new Sealed_test().showTest());
           // MessageBox.Show(text);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(new Pen(Color.Red),50,50,200,50);
        }
    }
}
