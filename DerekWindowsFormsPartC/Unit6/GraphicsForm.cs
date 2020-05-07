using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerekWindowsFormsPartC
{
    public partial class GraphicsForm : Form
    {
        private int y;
        private int x;
        private int w;
        private int h;
        public const int BYTE = 256;
        Pen myPen = new Pen(Color.Blue, 10);
        private Random generator = new Random();
        private char key;
        private bool keyPressed = false;

        public GraphicsForm()
        {
            InitializeComponent();
        }

        private Point getRandomPoint()
        {
            x = generator.Next(Width);
            y = generator.Next(Height);
            return new Point(x, y);
           
        }
        private void DrawScreen(object sender, PaintEventArgs e)
        {
            drawStrings(e.Graphics);
            drawRectangles(e.Graphics, 600, 100);
            drawHexagon(e.Graphics, 20, 400);

            if (keyPressed)
            {
                Point p1 = getRandomPoint();
                Point p2 = getRandomPoint();
                
                if (key == 'l')
                {
                    e.Graphics.DrawLine(myPen, p1, p2);
                }
                else if (key == 'r')
                {
                    Rectangle rectangle = new Rectangle(p1.X, p1.Y, 200, 100);
                    e.Graphics.DrawRectangle(myPen, rectangle);
                }
                else if(key == 'c')
                {
                    drawCircles(e.Graphics);
                }
               
                keyPressed = false;
            }
        }

        private void drawHexagon(Graphics graphics, int X, int Y)
        {
            int size = 100;
            Point[] hexagon = new Point[]
            {
                new Point(x, y), //left most corner
                new Point(x + size, y -size),
                new Point(x + size * 2, y - size),
                new Point(x + size * 3, y),
                new Point(x + size * 2, y + size),
                new Point(x + size, y + size),


            };

            graphics.DrawPolygon(myPen, hexagon);
            graphics.FillPolygon(Brushes.Yellow, hexagon);

            Font myfont = new Font("Courier", 30);
            graphics.DrawString("Godfrey's Hexagon", myfont, Brushes.Red, x, y+2*size);

            

        }

        private void drawRectangles(Graphics graphics, int x, int y)
        {
            w = 300; h = 200; int size = 20;

            Pen myPen = new Pen(Color.Blue, 10);

            graphics.DrawRectangle(myPen, x, y, w, h);
            graphics.FillRectangle(Brushes.Red, x, y, w, h);
            graphics.FillEllipse(Brushes.Yellow, x, y, w, h);

            y = 300;

            for(int i = 1; i <= 6; i++)
            {
                graphics.DrawRectangle(myPen, x, y, w, h);
                System.Threading.Thread.Sleep(100);


                x = x + size;
                y = y + size;
                w = w - 2 * size;
                h = h - 2 * size;
               
            }
        }

        private Color getRandomColor()
        {
            int r, g, b;

            r = generator.Next(BYTE);
            g = generator.Next(BYTE);
            b = generator.Next(BYTE);

            return Color.FromArgb(r, g, b);
        }

        private void drawStrings(Graphics graphics)
        {
            int fontSize = 30;
            x = 50;
            y = 20;
            Font myFont = new Font("Courier", fontSize);
            BackColor = Color.Yellow;

            for(int i = 1; i <= 6; i++)
            {
                graphics.Clear(BackColor);
                graphics.DrawString("Godfrey", myFont, Brushes.Red, x, y);

                //System.Threading.Thread.Sleep(100);
                y = y + fontSize;
            }
           
        }

        private void GraphicsForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressed = true;
            key = e.KeyChar;
            Refresh();
        }

        private void drawCircles(Graphics g)
        {
            x = 400; y = 100;

            int size = 400; int decrease = 15;

            Color color;

            Rectangle rectangle;

            for (int n = 1; n <= 10; n++)
            {
                Brush myBrush = new SolidBrush(getRandomColor());
                rectangle = new Rectangle(x, y, size, size);

                g.FillEllipse(myBrush, rectangle);

                size = size - 2 * decrease;
                x = x + decrease;
                y = y + decrease;

            }
        }
    }
}
