using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MazeControl : UserControl
    {
        public MazeControl()
        {
            InitializeComponent();
        }

        private void MazeControl_Load(object sender, EventArgs e)
        {

        }

        private void PaintMe(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.AntiqueWhite);
            Pen p = new Pen(Color.DarkMagenta);

            int n = 11;
            int margin = 9;
            int width = DisplayRectangle.Width;
            int height = DisplayRectangle.Height;
            int top = DisplayRectangle.Top;
            int left = DisplayRectangle.Left;
            float xStep = (width - 2 * margin) / n;
            float yStep = (height - 2 * margin) / n;
            for (int verticals = 0; verticals <= n; verticals++)
            {
                float x = left + margin + verticals * xStep;
                float y1 = top + margin;
                float y2 = top + margin + n*yStep;
                e.Graphics.DrawLine(p, x, y1, x, y2);
            }
            for (int horizontals = 0; horizontals <= n; horizontals++)
            {
                float x1 = left + margin;
                float y = top + margin + horizontals * yStep;
                float x2 = left + margin + n*xStep;
                e.Graphics.DrawLine(p, x1,y, x2,y);
            }

        }

        private void MazeControl_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
