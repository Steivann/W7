using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label judul = new Label();
            judul.Text = "Cinema";
            judul.Size = new Size(200, 100);
            judul.Location = new Point(333, 50);
            Controls.Add(judul);

            PictureBox Filmironman = new PictureBox();
            Filmironman.Image = Properties.Resources.foto1;
            Filmironman.Location = new Point(12, 100);
            Filmironman.Name = "Filmironman";
            Filmironman.Size = new Size(133, 175);
            Filmironman.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(Filmironman);

            Button ironman = new Button();
            ironman.Size = new Size(80, 20);
            ironman.Location = new Point(39, 285);
            ironman.Text = "Watch";
            Controls.Add(ironman);
            ironman.Click += Ironman_Click;

            PictureBox Filmit = new PictureBox();
            Filmit.Image = Properties.Resources.foto2;
            Filmit.Location = new Point(200, 100);
            Filmit.Name = "Filmit";
            Filmit.Size = new Size(133, 175);
            Filmit.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(Filmit);

            Button it = new Button();
            it.Size = new Size(80, 20);
            it.Location = new Point(227, 285);
            it.Text = "Watch";
            Controls.Add(it);
            it.Click += It_Click;

            PictureBox Filmjoker = new PictureBox();
            Filmjoker.Image = Properties.Resources.foto4;
            Filmjoker.Location = new Point(388, 100);
            Filmjoker.Name = "Filmjoker";
            Filmjoker.Size = new Size(133, 175);
            Filmjoker.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(Filmjoker);

            Button joker = new Button();
            joker.Size = new Size(80, 20);
            joker.Location = new Point(415, 285);
            joker.Text = "Watch";
            Controls.Add(joker);
            joker.Click += Joker_Click;

            PictureBox Filmbatman = new PictureBox();
            Filmbatman.Image = Properties.Resources.foto5;
            Filmbatman.Location = new Point(576, 100);
            Filmbatman.Name = "Filmbatman";
            Filmbatman.Size = new Size(133, 175);
            Filmbatman.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(Filmbatman);

            Button batman = new Button();
            batman.Size = new Size(80, 20);
            batman.Location = new Point(603, 285);
            batman.Text = "Watch";
            Controls.Add(batman);
            batman.Click += Batman_Click;

            PictureBox Filmdeadpool = new PictureBox();
            Filmdeadpool.Image = Properties.Resources.foto8;
            Filmdeadpool.Location = new Point(12, 340);
            Filmdeadpool.Name = "Filmdeadpool";
            Filmdeadpool.Size = new Size(133, 175);
            Filmdeadpool.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(Filmdeadpool);

            Button deadpool = new Button();
            deadpool.Size = new Size(80, 20);
            deadpool.Location = new Point(39, 525);
            deadpool.Text = "Watch";
            Controls.Add(deadpool);
            deadpool.Click += Deadpool_Click;

            PictureBox Filmlightyear = new PictureBox();
            Filmlightyear.Image = Properties.Resources.foto7;
            Filmlightyear.Location = new Point(200, 340);
            Filmlightyear.Name = "Filmlightyear";
            Filmlightyear.Size = new Size(133, 175);
            Filmlightyear.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(Filmlightyear);

            Button lightyear = new Button();
            lightyear.Size = new Size(80, 20);
            lightyear.Location = new Point(227, 525);
            lightyear.Text = "Watch";
            Controls.Add(lightyear);
            lightyear.Click += Lightyear_Click;

            PictureBox Filmjurasic = new PictureBox();
            Filmjurasic.Image = Properties.Resources.foto6;
            Filmjurasic.Location = new Point(388, 340);
            Filmjurasic.Name = "Filmjurasic";
            Filmjurasic.Size = new Size(133, 175);
            Filmjurasic.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(Filmjurasic);

            Button jurasic = new Button();
            jurasic.Size = new Size(80, 20);
            jurasic.Location = new Point(415, 525);
            jurasic.Text = "Watch";
            Controls.Add(jurasic);
            jurasic.Click += Jurasic_Click;

            PictureBox Filmscream = new PictureBox();
            Filmscream.Image = Properties.Resources.foto9;
            Filmscream.Location = new Point(576, 340);
            Filmscream.Name = "Filmscream";
            Filmscream.Size = new Size(133, 175);
            Filmscream.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(Filmscream);

            Button scream = new Button();
            scream.Size = new Size(80, 20);
            scream.Location = new Point(603, 525);
            scream.Text = "Watch";
            Controls.Add(scream);
            scream.Click += Scream_Click;

        }

        private void Scream_Click(object sender, EventArgs e)
        {
            Formfilmscream movie = new Formfilmscream();
            movie.Show();
        }

        private void Jurasic_Click(object sender, EventArgs e)
        {
            Formfilmjurasic movie = new Formfilmjurasic();
            movie.Show();
        }

        private void Lightyear_Click(object sender, EventArgs e)
        {
            Formfilmlightyear movie = new Formfilmlightyear();
            movie.Show();
        }

        private void Deadpool_Click(object sender, EventArgs e)
        {
            Formfilmdeadpool movie = new Formfilmdeadpool();
            movie.Show();
        }

        private void Batman_Click(object sender, EventArgs e)
        {
            Formfilmbatman movie = new Formfilmbatman();
            movie.Show();
        }

        private void Joker_Click(object sender, EventArgs e)
        {
            Formfilmjoker movie = new Formfilmjoker();
            movie.Show();
        }

        private void It_Click(object sender, EventArgs e)
        {
            formfilmit movie = new formfilmit();
            movie.Show();
        }

        private void Ironman_Click(object sender, EventArgs e)
        {
            FormIronman movie = new FormIronman();
            movie.Show();
        }
    }
}
