using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promo_Pemesanan
{
    public partial class Form1 : Form
    {
        private Size formOriginalSize;
        private Rectangle recpanel1;

        private Rectangle recguna2PictureBox4;
        private Rectangle recguna2Button4;
        private Rectangle recguna2Button5;
        private Rectangle recguna2Button6;
        private Rectangle recguna2Button7;
        private Rectangle recguna2Button8;
        private Rectangle recguna2Button9;
        private Rectangle recguna2ImageButton1;
        private Rectangle recguna2ImageButton2;
        private Rectangle recguna2ImageButton3;

        private Rectangle recguna2Panel1;
        private Rectangle recguna2PictureBox1;
        private Rectangle reclabel1;
        private Rectangle reclabel2;
        private Rectangle reclabel3;
        private Rectangle reclabel4;
        private Rectangle recguna2Button1;

        private Rectangle recguna2Panel2;
        private Rectangle recguna2PictureBox2;
        private Rectangle reclabel5;
        private Rectangle reclabel6;
        private Rectangle reclabel7;
        private Rectangle reclabel8;
        private Rectangle recguna2Button2;

        private Rectangle recguna2Panel3;
        private Rectangle recguna2PictureBox3;
        private Rectangle reclabel9;
        private Rectangle reclabel10;
        private Rectangle reclabel11;
        private Rectangle reclabel12;
        private Rectangle recguna2Button3;


        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;

            recpanel1 = new Rectangle(panel1.Location, panel1.Size);

            recguna2PictureBox4 = new Rectangle(guna2PictureBox4.Location, guna2PictureBox4.Size);
            recguna2Button4 = new Rectangle(guna2Button4.Location, guna2Button4.Size);
            recguna2Button5 = new Rectangle(guna2Button5.Location, guna2Button5.Size);
            recguna2Button6 = new Rectangle(guna2Button6.Location, guna2Button6.Size);
            recguna2Button7 = new Rectangle(guna2Button7.Location, guna2Button7.Size);
            recguna2Button8 = new Rectangle(guna2Button8.Location, guna2Button8.Size);
            recguna2Button9 = new Rectangle(guna2Button9.Location, guna2Button9.Size);
            recguna2ImageButton1 = new Rectangle(guna2ImageButton1.Location, guna2ImageButton1.Size);
            recguna2ImageButton2 = new Rectangle(guna2ImageButton2.Location, guna2ImageButton2.Size);
            recguna2ImageButton3 = new Rectangle(guna2ImageButton3.Location, guna2ImageButton3.Size);

            recguna2Panel1 = new Rectangle(guna2Panel1.Location, guna2Panel1.Size);
            recguna2PictureBox1 = new Rectangle(guna2PictureBox1.Location, guna2PictureBox1.Size);
            reclabel1 = new Rectangle(label1.Location, label1.Size);
            reclabel2 = new Rectangle(label2.Location, label2.Size);
            reclabel3 = new Rectangle(label3.Location, label3.Size);
            reclabel4 = new Rectangle(label4.Location, label4.Size);
            recguna2Button1 = new Rectangle(guna2Button1.Location, guna2Button1.Size);

            recguna2Panel2 = new Rectangle(guna2Panel2.Location, guna2Panel2.Size);
            recguna2PictureBox2 = new Rectangle(guna2PictureBox2.Location, guna2PictureBox2.Size);
            reclabel5 = new Rectangle(label5.Location, label5.Size);
            reclabel6 = new Rectangle(label6.Location, label6.Size);
            reclabel7 = new Rectangle(label7.Location, label7.Size);
            reclabel8 = new Rectangle(label8.Location, label8.Size);
            recguna2Button2 = new Rectangle(guna2Button2.Location, guna2Button2.Size);

            recguna2Panel3 = new Rectangle(guna2Panel3.Location, guna2Panel3.Size);
            recguna2PictureBox3 = new Rectangle(guna2PictureBox2.Location, guna2PictureBox2.Size);
            reclabel9 = new Rectangle(label9.Location, label9.Size);
            reclabel10 = new Rectangle(label10.Location, label10.Size);
            reclabel11 = new Rectangle(label11.Location, label11.Size);
            reclabel12 = new Rectangle(label12.Location, label12.Size);
            recguna2Button3 = new Rectangle(guna2Button3.Location, guna2Button3.Size);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(panel1, recpanel1);
            resize_Control(guna2PictureBox4, recguna2PictureBox4);
            resize_Control(guna2Button4, recguna2Button4);
            resize_Control(guna2Button5, recguna2Button5);
            resize_Control(guna2Button6, recguna2Button6);
            resize_Control(guna2Button7, recguna2Button7);
            resize_Control(guna2Button8, recguna2Button8);
            resize_Control(guna2Button9, recguna2Button9);
            resize_Control(guna2ImageButton1, recguna2ImageButton1);
            resize_Control(guna2ImageButton2, recguna2ImageButton2);
            resize_Control(guna2ImageButton3, recguna2ImageButton3);

            resize_Control(guna2Panel1, recguna2Panel1);
            resize_Control(guna2PictureBox1, recguna2PictureBox1);
            resize_Control(label1, reclabel1);
            resize_Control(label2, reclabel2);
            resize_Control(label3, reclabel3);
            resize_Control(label4, reclabel4);
            resize_Control(guna2Button1, recguna2Button1);

            resize_Control(guna2Panel2, recguna2Panel2);
            resize_Control(guna2PictureBox2, recguna2PictureBox2);
            resize_Control(label5, reclabel5);
            resize_Control(label6, reclabel6);
            resize_Control(label7, reclabel7);
            resize_Control(label8, reclabel8);
            resize_Control(guna2Button2, recguna2Button2);

            resize_Control(guna2Panel3, recguna2Panel3);
            resize_Control(guna2PictureBox3, recguna2PictureBox3);
            resize_Control(label9, reclabel9);
            resize_Control(label10, reclabel10);
            resize_Control(label11, reclabel11);
            resize_Control(label12, reclabel12);
            resize_Control(guna2Button3, recguna2Button3);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void promo_Load(object sender, EventArgs e)
        {

        }
        private bool guna2Button1MouseClick = false;
        private bool guna2Button2MouseClick = false;
        private bool guna2Button3MouseClick = false;
        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (guna2Button1MouseClick)
            {
                guna2Button1.Text = "Gunakan";
                guna2Button1.ForeColor = Color.White;
                guna2Button1.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button1MouseClick = false;
            }
            else
            {
                guna2Button1.Text = "Digunakan";
                guna2Button1.ForeColor = Color.WhiteSmoke;
                guna2Button1.FillColor = Color.FromArgb(102, 98, 98);
                MessageBox.Show("Promo Berhasil Digunakan!");

                guna2Button1MouseClick = true;
            }
            if (guna2Button2MouseClick)
            {
                guna2Button2.Text = "Gunakan";
                guna2Button2.ForeColor = Color.White;
                guna2Button2.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button2MouseClick = false;
            }
            else if (guna2Button3MouseClick)
            {
                guna2Button3.Text = "Gunakan";
                guna2Button3.ForeColor = Color.White;
                guna2Button3.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button3MouseClick = false;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2Button2MouseClick)
            {
                guna2Button2.Text = "Gunakan";
                guna2Button2.ForeColor = Color.White;
                guna2Button2.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button2MouseClick = false;
            }
            else
            {
                guna2Button2.Text = "Digunakan";
                guna2Button2.ForeColor = Color.WhiteSmoke;
                guna2Button2.FillColor = Color.FromArgb(102, 98, 98);
                MessageBox.Show("Promo Berhasil Digunakan!");

                guna2Button2MouseClick = true;
            }
            if (guna2Button1MouseClick)
            {
                guna2Button1.Text = "Gunakan";
                guna2Button1.ForeColor = Color.White;
                guna2Button1.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button1MouseClick = false;
            }
            else if (guna2Button3MouseClick)
            {
                guna2Button3.Text = "Gunakan";
                guna2Button3.ForeColor = Color.White;
                guna2Button3.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button3MouseClick = false;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2Button3MouseClick)
            {
                guna2Button3.Text = "Gunakan";
                guna2Button3.ForeColor = Color.White;
                guna2Button3.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button3MouseClick = false;
            }
            else
            {
                guna2Button3.Text = "Digunakan";
                guna2Button3.ForeColor = Color.WhiteSmoke;
                guna2Button3.FillColor = Color.FromArgb(102, 98, 98);
                MessageBox.Show("Promo Berhasil Digunakan!");

                guna2Button3MouseClick = true;
            }
            if (guna2Button1MouseClick)
            {
                guna2Button1.Text = "Gunakan";
                guna2Button1.ForeColor = Color.White;
                guna2Button1.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button1MouseClick = false;
            }
            else if (guna2Button3MouseClick)
            {
                guna2Button2.Text = "Gunakan";
                guna2Button2.ForeColor = Color.White;
                guna2Button2.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button2MouseClick = false;
            }
        }
    }
}