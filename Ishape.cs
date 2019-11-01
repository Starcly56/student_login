using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace login_of__student
{
    interface Ishape
    {
        int X { set; get; }
        int Y { set; get; }
        int height { set; get; }
        int width{ set; get; }
        //int radius { get; set; }
        float sangle { get; set; }
        float swangle { get; set; }
        void drawShape(Graphics g);
        void drawCircle(Graphics g);
        void drawCCircle(Graphics g);
    }
}
