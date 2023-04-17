using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace W7
{
    public partial class Formfilmlightyear : Form
    {
        List<Button> buttonlist1 = new List<Button>();
        List<Button> buttonlist2 = new List<Button>();
        List<Button> buttonlist3 = new List<Button>();
        Panel panell = new Panel();
        Random gatau = new Random();

        int a = 0;
        int b = 0;
        int bantu = 0;

        public Formfilmlightyear()
        {
            InitializeComponent();
        }

        private void Formfilmlightyear_Load(object sender, EventArgs e)
        {
            Button jadwal1 = new Button();
            jadwal1.Size = new Size(70, 70);
            jadwal1.Location = new Point(20, 50);
            jadwal1.Text = "08.00";
            Controls.Add(jadwal1);
            jadwal1.Click += Jadwal1_Click;

            Button jadwal2 = new Button();
            jadwal2.Size = new Size(70, 70);
            jadwal2.Location = new Point(20, 125);
            jadwal2.Text = "10.00";
            Controls.Add(jadwal2);
            jadwal2.Click += Jadwal2_Click;

            Button jadwal3 = new Button();
            jadwal3.Size = new Size(70, 70);
            jadwal3.Location = new Point(20, 200);
            jadwal3.Text = "12.00";
            Controls.Add(jadwal3);
            jadwal3.Click += Jadwal3_Click;

            Button back = new Button();
            back.Size = new Size(70, 30);
            back.Location = new Point(30, 300);
            back.Text = "Back";
            Controls.Add(back);
            back.Click += Back_Click;

            panell.Location = new Point(240, 25);
            panell.Size = new Size(280, 300);
            panell.BackColor = Color.White;
            panell.TabIndex = 0;
            Controls.Add(panell);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Okei2_Click(object sender, EventArgs e)
        {
            Label pilihan = new Label();
            pilihan.Location = new Point(5, 240);
            pilihan.Size = new Size(300, 300);
            pilihan.Text = "Seat Choose : ";
            panell.Controls.Add(pilihan);

            foreach (Button a in buttonlist2)
            {
                if (a.BackColor == Color.YellowGreen)
                {
                    a.BackColor = Color.Red;
                    a.Enabled = false;
                    pilihan.Text = "Seat Choose : ";
                }
            }
        }

        private void Okei3_Click(object sender, EventArgs e)
        {
            Label pilihan = new Label();
            pilihan.Location = new Point(5, 240);
            pilihan.Size = new Size(300, 300);
            pilihan.Text = "Seat Choose : ";
            panell.Controls.Add(pilihan);

            foreach (Button a in buttonlist3)
            {
                if (a.BackColor == Color.YellowGreen)
                {
                    a.BackColor = Color.Red;
                    a.Enabled = false;
                    pilihan.Text = "Seat Choose : ";
                }
            }
        }

        private void Okei1_Click(object sender, EventArgs e)
        {
            Label pilihan = new Label();
            pilihan.Location = new Point(5, 240);
            pilihan.Size = new Size(300, 300);
            pilihan.Text = "Seat Choose : ";
            panell.Controls.Add(pilihan);

            foreach (Button a in buttonlist1)
            {
                if (a.BackColor == Color.YellowGreen)
                {
                    a.BackColor = Color.Red;
                    a.Enabled = false;
                    pilihan.Text = "Seat Choose : ";
                }
            }
        }
        private void Okei_Click(object sender, EventArgs e)
        {

        }
        int cek = 0;
        private void Jadwal3_Click(object sender, EventArgs e)
        {


            panell.Controls.Clear();

            Button reset3 = new Button();
            reset3.Size = new Size(80, 20);
            reset3.Location = new Point(5, 275);
            reset3.Text = "Reset";
            panell.Controls.Add(reset3);
            reset3.Click += Reset3_Click;
            Button okei3 = new Button();
            okei3.Size = new Size(80, 20);
            okei3.Location = new Point(190, 275);
            okei3.Text = "Reserve";
            panell.Controls.Add(okei3);
            okei3.Click += Okei3_Click;

            a = 0;
            b = 0;

            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    Button kursi3 = new Button();
                    kursi3.Size = new Size(20, 20);
                    kursi3.Location = new Point(10 + a, 10 + b);
                    kursi3.BackColor = Color.Black;
                    kursi3.Tag = "(" + j.ToString() + "," + i.ToString() + ") ";
                    buttonlist3.Add(kursi3);
                    kursi3.Click += Kursi3_Click;
                    bantu++;
                    a += 20;
                }
                a = 0;
                b += 20;
            }

            if (cek == 0)
            {
                for (int a = 0; a < 70; a++)
                {
                    int acak = gatau.Next(0, 100);
                    buttonlist3[acak].BackColor = Color.Red;
                    buttonlist3[acak].Enabled = false;
                }
            }
            cek++;
            foreach (Button buat in buttonlist3)
            {
                panell.Controls.Add(buat);
            }
        }

        private void Reset3_Click(object sender, EventArgs e)
        {
            foreach (Button button in buttonlist3)
            {
                if (button.BackColor == Color.Red)
                {
                    button.BackColor = Color.Black;
                    button.Enabled = true;
                }

            }
        }

        private void Jadwal2_Click(object sender, EventArgs e)
        {


            panell.Controls.Clear();
            Button reset2 = new Button();
            reset2.Size = new Size(80, 20);
            reset2.Location = new Point(5, 275);
            reset2.Text = "Reset";
            panell.Controls.Add(reset2);
            reset2.Click += Reset2_Click;


            Button okei2 = new Button();
            okei2.Size = new Size(80, 20);
            okei2.Location = new Point(190, 275);
            okei2.Text = "Reserve";
            panell.Controls.Add(okei2);
            okei2.Click += Okei2_Click;

            Label pilihan = new Label();
            pilihan.Location = new Point(5, 240);
            pilihan.Size = new Size(300, 300);
            pilihan.Text = "Seat Choose : ";
            panell.Controls.Add(pilihan);



            a = 0;
            b = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button kursi2 = new Button();
                    kursi2.Size = new Size(20, 20);
                    kursi2.Location = new Point(10 + a, 10 + b);
                    kursi2.BackColor = Color.Black;
                    kursi2.Tag = "(" + j.ToString() + "," + i.ToString() + ") ";
                    buttonlist2.Add(kursi2);
                    kursi2.Click += Kursi2_Click;
                    bantu++;
                    a += 20;
                }
                a = 0;
                b += 20;
            }
            for (int a = 0; a < 70; a++)
            {
                int acak = gatau.Next(0, 100);
                buttonlist2[acak].BackColor = Color.Red;
                buttonlist2[acak].Enabled = false;
            }
            foreach (Button buat in buttonlist2)
            {
                panell.Controls.Add(buat);
            }
        }

        private void Reset2_Click(object sender, EventArgs e)
        {
            foreach (Button button in buttonlist2)
            {
                if (button.BackColor == Color.Red)
                {
                    button.BackColor = Color.Black;
                    button.Enabled = true;
                }

            }
        }

        private void Jadwal1_Click(object sender, EventArgs e)
        {


            panell.Controls.Clear();
            Button okei1 = new Button();
            okei1.Size = new Size(80, 20);
            okei1.Location = new Point(190, 275);
            okei1.Text = "Reserve";
            panell.Controls.Add(okei1);
            okei1.Click += Okei1_Click;

            Button reset1 = new Button();
            reset1.Size = new Size(80, 20);
            reset1.Location = new Point(5, 275);
            reset1.Text = "Reset";
            panell.Controls.Add(reset1);
            reset1.Click += Reset1_Click;

            Label pilihan = new Label();
            pilihan.Location = new Point(5, 240);
            pilihan.Size = new Size(300, 300);
            pilihan.Text = "Seat Choose : ";
            panell.Controls.Add(pilihan);

            a = 0;
            b = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button kursi1 = new Button();
                    kursi1.Size = new Size(20, 20);
                    kursi1.Location = new Point(10 + a, 10 + b);
                    kursi1.BackColor = Color.Black;
                    kursi1.Tag = "(" + j.ToString() + "," + i.ToString() + ") ";
                    buttonlist1.Add(kursi1);
                    kursi1.Click += Kursi1_Click;
                    bantu++;
                    a += 20;
                }
                a = 0;
                b += 20;
            }
            for (int a = 0; a < 70; a++)
            {
                int acak = gatau.Next(0, 100);
                buttonlist1[acak].BackColor = Color.Red;
                buttonlist1[acak].Enabled = false;
            }
            foreach (Button buat in buttonlist1)
            {
                panell.Controls.Add(buat);
            }

        }

        private void Reset1_Click(object sender, EventArgs e)
        {
            foreach (Button button in buttonlist1)
            {
                if (button.BackColor == Color.Red)
                {
                    button.BackColor = Color.Black;
                    button.Enabled = true;
                }

            }
        }
        private void Kursi3_Click(object sender, EventArgs e)
        {
            Label pilihan = new Label();
            pilihan.Location = new Point(5, 240);
            pilihan.Size = new Size(300, 300);
            pilihan.Text = "Seat Choose : ";
            panell.Controls.Add(pilihan);

            Button sold = sender as Button;
            foreach (Button duduk in buttonlist3)
            {
                panell.Controls.Add(duduk);
            }
            if (sold.BackColor == Color.Black)
            {
                sold.BackColor = Color.YellowGreen;
                pilihan.Text += sold.Tag.ToString();
            }
        }



        private void Kursi1_Click(object sender, EventArgs e)
        {
            Label pilihan = new Label();
            pilihan.Location = new Point(5, 240);
            pilihan.Size = new Size(300, 300);
            pilihan.Text = "Seat Choose : ";
            panell.Controls.Add(pilihan);

            Button sold = sender as Button;
            foreach (Button duduk in buttonlist3)
            {
                panell.Controls.Add(duduk);
            }
            if (sold.BackColor == Color.Black)
            {
                sold.BackColor = Color.YellowGreen;
                pilihan.Text += sold.Tag.ToString();
            }
        }

        private void Kursi2_Click(object sender, EventArgs e)
        {
            Label pilihan = new Label();
            pilihan.Location = new Point(5, 240);
            pilihan.Size = new Size(300, 300);
            pilihan.Text = "Seat Choose : ";
            panell.Controls.Add(pilihan);

            Button sold = sender as Button;
            foreach (Button duduk in buttonlist3)
            {
                panell.Controls.Add(duduk);
            }
            if (sold.BackColor == Color.Black)
            {
                sold.BackColor = Color.YellowGreen;
                pilihan.Text += sold.Tag.ToString();
            }
        }
    }
}
