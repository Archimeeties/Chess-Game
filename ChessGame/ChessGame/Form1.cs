using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        public Form1()
        {
            InitializeComponent();

            graphics = CreateGraphics();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Font font = new Font("Tahoma", 6, FontStyle.Regular);

            for (int x = 0; x < Width; x += 70)
            {
                if (x < 630)
                {
                    // Draw vertical lines
                    graphics.DrawLine(Pens.Black, x, 0, x, 560);

                    // Draw grid numbers along the x-axis
                    graphics.DrawString(x.ToString(), font, Brushes.Black, x, 560);
                }
            }

            for (int y = 0; y < Height; y += 70)
            {
                if (y < 630)
                {
                    // Draw horizontal lines
                    graphics.DrawLine(Pens.Black, 0, y, 560, y);

                    // Draw grid numbers along the y-axis
                    graphics.DrawString(y.ToString(), font, Brushes.Black, 0, y);
                }
            }
        }
    }
}
