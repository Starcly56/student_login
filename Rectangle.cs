using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace login_of__student
{
    public class Rectangle:Ishape
    {
        public int X { set; get; }
        public int Y { set; get; }
        public int height { set; get; }
        public int width { get; set; }
        //public int radius { get; set; }
        public float sangle { get; set; }
        public float swangle { get; set; }
        public void  drawShape(Graphics g)
        {
            //Pen p = new Pen(Color.Red);
            g.DrawRectangle(new Pen(Color.Red), X, Y, width, height);
        }
        public void drawCircle(Graphics g)
        {
            //g.DrawPie(new Pen(Color.Black),X, Y, width, height, sangle, swangle);
           // g.DrawClosedCurve(new Pen(Color.Black));
            g.DrawEllipse(new Pen(Color.Black), X, Y, width, height);
        }
        public void drawCCircle(Graphics g)
        {
            //g.DrawPie(new Pen(Color.Black),X, Y, width, height, sangle, swangle);

            g.DrawArc(new Pen(Color.Black), X, Y, width, height, sangle, swangle);
        }
    }
}
