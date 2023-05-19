using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders._4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int gspuan = 0;
        int fbpuan = 0;
        int tspuan = 0;
        int bjkpuan =0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bsl:
            button1.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 6);
            int d = rastgele.Next(0, 6);


            label3.Text = a.ToString();
            label6.Text = b.ToString();
            label8.Text = c.ToString();
            label7.Text = d.ToString();

            if (Convert.ToInt32(label3.Text) > Convert.ToInt32(label6.Text))
            {
                gspuan = gspuan+3;
                label18.Text = gspuan.ToString();
            }
            else if (Convert.ToInt32(label3.Text) < Convert.ToInt32(label6.Text))
            {
                fbpuan = fbpuan + 3;
                label13.Text = fbpuan.ToString();
            }
            else 
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                label13.Text = fbpuan.ToString();
                label18.Text = gspuan.ToString();
            }


            if (Convert.ToInt32(label8.Text) > Convert.ToInt32(label7.Text))
            {
                bjkpuan = bjkpuan + 3;
                label14.Text = bjkpuan.ToString();
            }
            else if (Convert.ToInt32(label3.Text) < Convert.ToInt32(label6.Text))
            {
                tspuan =tspuan + 3;
                label15.Text = tspuan.ToString();
            }
            else
            {
                tspuan = tspuan+ 1;
                bjkpuan = bjkpuan+ 1;
                label14.Text = bjkpuan.ToString();
                label15.Text = tspuan.ToString();
            }






        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 6);
            int d = rastgele.Next(0, 6);


            label26.Text = a.ToString();
            label23.Text = b.ToString();
            label21.Text = c.ToString();
            label22.Text = d.ToString();

            if (Convert.ToInt32(label26.Text) > Convert.ToInt32(label23.Text))
            {
                gspuan = gspuan + 3;
                label18.Text = gspuan.ToString();
            }
            else if (Convert.ToInt32(label26.Text) < Convert.ToInt32(label23.Text))
            {
                fbpuan = fbpuan + 3;
                label13.Text = fbpuan.ToString();
            }
            else
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                label13.Text = fbpuan.ToString();
                label18.Text = gspuan.ToString();
            }


            if (Convert.ToInt32(label21.Text) > Convert.ToInt32(label22.Text))
            {
                bjkpuan = bjkpuan + 3;
                label14.Text = bjkpuan.ToString();
            }
            else if (Convert.ToInt32(label21.Text) < Convert.ToInt32(label22.Text))
            {
                tspuan = tspuan + 3;
                label15.Text = tspuan.ToString();
            }
            else
            {
                tspuan = tspuan + 1;
                bjkpuan = bjkpuan + 1;
                label14.Text = bjkpuan.ToString();
                label15.Text = tspuan.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 6);
            int d = rastgele.Next(0, 6);


            label36.Text = a.ToString();
            label33.Text = b.ToString();
            label31.Text = c.ToString();
            label32.Text = d.ToString();

            if (Convert.ToInt32(label36.Text) > Convert.ToInt32(label33.Text))
            {
                gspuan = gspuan + 3;
                label18.Text = gspuan.ToString();
            }
            else if (Convert.ToInt32(label36.Text) < Convert.ToInt32(label33.Text))
            {
                fbpuan = fbpuan + 3;
                label13.Text = fbpuan.ToString();
            }
            else
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                label13.Text = fbpuan.ToString();
                label18.Text = gspuan.ToString();
            }


            if (Convert.ToInt32(label31.Text) > Convert.ToInt32(label32.Text))
            {
                bjkpuan = bjkpuan + 3;
                label14.Text = bjkpuan.ToString();
            }
            else if (Convert.ToInt32(label31.Text) < Convert.ToInt32(label32.Text))
            {
                tspuan = tspuan + 3;
                label15.Text = tspuan.ToString();
            }
            else
            {
                tspuan = tspuan + 1;
                bjkpuan = bjkpuan + 1;
                label14.Text = bjkpuan.ToString();
                label15.Text = tspuan.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if(Convert.ToInt32(label18.Text)>Convert.ToInt32(label13.Text) && Convert.ToInt16(label18.Text)>Convert.ToInt32(label14.Text) && Convert.ToInt32(label18.Text)> Convert.ToInt32(label15.Text))
            {
                label39.Text = "Şampiyon Galatasaray !!!!";
                pictureBox1.ImageLocation = "C:\\Users\\talha\\OneDrive\\Pictures\\Film Rulosu\\gs.png";
                axWindowsMediaPlayer1.URL = "C:\\Users\\talha\\Music\\gs.mp3";
            }


            if (Convert.ToInt32(label13.Text) > Convert.ToInt32(label18.Text) && Convert.ToInt16(label13.Text) > Convert.ToInt32(label14.Text) && Convert.ToInt32(label13.Text) > Convert.ToInt32(label15.Text))
            {
                label39.Text = "Şampiyon Fenerbahçe !!!!";
                pictureBox1.ImageLocation = "C:\\Users\\talha\\OneDrive\\Pictures\\Film Rulosu\\fb.jpg";
                axWindowsMediaPlayer1.URL = "C:\\Users\\talha\\Music\\fb.mp3"; ;
            }

            if (Convert.ToInt32(label14.Text) > Convert.ToInt32(label18.Text) && Convert.ToInt16(label14.Text) > Convert.ToInt32(label13.Text) && Convert.ToInt32(label14.Text) > Convert.ToInt32(label15.Text))
            {
                label39.Text = "Şampiyon Beşiktaş !!!!";
                pictureBox1.ImageLocation = "C:\\Users\\talha\\OneDrive\\Pictures\\Film Rulosu\\bjk.png";
                axWindowsMediaPlayer1.URL = "C:\\Users\\talha\\Music\\bjk.mp3";
            }


            if (Convert.ToInt32(label15.Text) > Convert.ToInt32(label18.Text) && Convert.ToInt16(label15.Text) > Convert.ToInt32(label13.Text) && Convert.ToInt32(label15.Text) > Convert.ToInt32(label14.Text))
            {
                label39.Text = "Şampiyon Trabzonspor !!!!";
                pictureBox1.ImageLocation = "C:\\Users\\talha\\OneDrive\\Pictures\\Film Rulosu\\ts.jpg";
                axWindowsMediaPlayer1.URL = "C:\\Users\\talha\\Music\\ts.mp3";
            }

            if (Convert.ToInt32(label18.Text)==Convert.ToInt32(label13.Text) || Convert.ToInt16(label18.Text) == Convert.ToInt32(label14.Text) || Convert.ToInt32(label18.Text) == Convert.ToInt32(label15.Text))
            {
                button3.Enabled = true;
            }
            if (Convert.ToInt32(label13.Text)== Convert.ToInt32(label18.Text)|| Convert.ToInt16(label13.Text) == Convert.ToInt32(label14.Text) || Convert.ToInt32(label13.Text) == Convert.ToInt32(label15.Text))

            {
                button3.Enabled = true;
            }

            if (Convert.ToInt32(label14.Text)==Convert.ToInt32(label18.Text) || Convert.ToInt16(label14.Text)== Convert.ToInt32(label13.Text) || Convert.ToInt32(label14.Text) == Convert.ToInt32(label15.Text))
            {
                button3.Enabled = true;
            }

            if (Convert.ToInt32(label15.Text)== Convert.ToInt32(label18.Text) || Convert.ToInt16(label15.Text) == Convert.ToInt32(label13.Text) || Convert.ToInt32(label15.Text) == Convert.ToInt32(label14.Text))
            {
                button3.Enabled = true;
            }



        }
    }
}
