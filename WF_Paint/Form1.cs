using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5_WF_Vasilchenko_DrawThing
{
    public partial class Form1 : Form
    {
        private SolidBrush br;
        private Graphics gr;
        private bool flagDrawing;
        private bool flagRectangle;
        private bool flagEllipse;
        private bool flagLine;
        private Point begin;
        private Point end;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            br = new SolidBrush(cPanel.BackColor);
            gr = paintPanel.CreateGraphics();
        }

        private void cPanel_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                cPanel.BackColor = colorDialog1.Color;
                br.Color = colorDialog1.Color;
            }
        }

        private void paintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (flagLine)
            {
                var pen = new Pen(br.Color);
                pen.Width = (float)trackBar1.Value;
                gr.DrawLine(pen, begin, end);
            }
            flagDrawing = false;            
        }

        private void paintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            flagDrawing = true;
            if (flagRectangle)
            {
                gr.DrawRectangle(new Pen(br.Color), e.X, e.Y, (int)widNumber.Value * 10,
                    (int)lenNumber.Value * 10);
            }

            if (flagEllipse)
            {
                gr.DrawEllipse(new Pen(br.Color),e.X,e.Y,(int) radNumber.Value,(int) radNumber.Value);
            }

            if (flagLine)
            {
                begin = new Point(e.X, e.Y);
            }
        }

        private void paintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (flagDrawing && !flagRectangle && !flagEllipse && !flagLine)
            {
                gr.FillEllipse(br, e.X, e.Y, trackBar1.Value, trackBar1.Value);
            }

            if (flagLine)
            {
                end = new Point(e.X, e.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            br.Color = Color.White;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                flagRectangle = true;
                flagLine = false;
                flagEllipse = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else flagRectangle = false;
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                flagRectangle = false;
                flagLine = false;
                flagEllipse = true;
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
            else flagEllipse = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                flagRectangle = false;
                flagLine = true;
                flagEllipse = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
            else flagLine = false;
        }
    }
}