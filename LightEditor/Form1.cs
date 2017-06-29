using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightEditor
{
    public partial class Form1 : Form
    {
        public int indiceCanaux = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void showControleurFixture()
        {
            //*******On affiche le UserControle au centre de la Form***************
            if (!panel_fixture.Controls.Contains(UserControl_Fixture.Instance))
            {
                panel_fixture.Controls.Add(UserControl_Fixture.Instance);
                UserControl_Fixture.Instance.Dock = DockStyle.Fill;
                UserControl_Fixture.Instance.BringToFront();
            }
            else
            {
                UserControl_Fixture.Instance.BringToFront();
            }
        }
        private void button_rgb_Click(object sender, EventArgs e)
        {
            showControleurFixture();
            RGB Rgb = new RGB();
            for(int i = 0; i < Rgb.indice_canaux; i++)
            {
                Bitmap imgBitmap = new Bitmap(Program.pathLibrary + Rgb.path_image[i]);
                UserControl_Fixture.Instance.dataGridView1.Rows.Add((indiceCanaux + 1).ToString(), Rgb.fonction[i], imgBitmap);
                indiceCanaux++;
            }
        }
        private void button_cym_Click(object sender, EventArgs e)
        {
            showControleurFixture();
            CYM Cym = new CYM();
            for (int i = 0; i < Cym.indice_canaux; i++)
            {
                Bitmap imgBitmap = new Bitmap(Program.pathLibrary + Cym.path_image[i]);
                UserControl_Fixture.Instance.dataGridView1.Rows.Add((indiceCanaux + 1).ToString(), Cym.fonction[i], imgBitmap);
                indiceCanaux++;
            }
        }
        private void button_dimmer_Click(object sender, EventArgs e)
        {
            showControleurFixture();
            Dimmer dimmer = new Dimmer();
            Bitmap imgBitmap = new Bitmap(Program.pathLibrary + dimmer.path_image[0]);
            UserControl_Fixture.Instance.dataGridView1.Rows.Add((indiceCanaux + 1).ToString(), dimmer.fonction[0], imgBitmap);
            indiceCanaux++;
        }

        private void button_pan_tilt_Click(object sender, EventArgs e)
        {
            showControleurFixture();
            PanTilt PanTilt = new PanTilt();
            for (int i = 0; i < PanTilt.indice_canaux; i++)
            {
                Bitmap imgBitmap = new Bitmap(Program.pathLibrary + PanTilt.path_image[i]);
                UserControl_Fixture.Instance.dataGridView1.Rows.Add((indiceCanaux + 1).ToString(), PanTilt.fonction[i], imgBitmap);
                indiceCanaux++;
            }
        }

        private void button_gobo_Click(object sender, EventArgs e)
        {
            showControleurFixture();
            Gobo Gobo = new Gobo();
            Bitmap imgBitmap = new Bitmap(Program.pathLibrary + Gobo.path_image[0]);
            UserControl_Fixture.Instance.dataGridView1.Rows.Add((indiceCanaux + 1).ToString(), Gobo.fonction[0], imgBitmap);
            indiceCanaux++;
        }

        private void button_color_Click(object sender, EventArgs e)
        {
            showControleurFixture();
            Color Color = new Color();
            Bitmap imgBitmap = new Bitmap(Program.pathLibrary + Color.path_image[0]);
            UserControl_Fixture.Instance.dataGridView1.Rows.Add((indiceCanaux + 1).ToString(), Color.fonction[0], imgBitmap);
            indiceCanaux++;
        }

        private void button_undef_Click(object sender, EventArgs e)
        {
            showControleurFixture();
            Undef Undef = new Undef();
            Bitmap imgBitmap = new Bitmap(Program.pathLibrary + Undef.path_image[0]);
            UserControl_Fixture.Instance.dataGridView1.Rows.Add((indiceCanaux + 1).ToString(), Undef.fonction[0], imgBitmap);
            indiceCanaux++;
        }
    }


    //****************************************************************************************
    //                                 Objets des cannaux
    //****************************************************************************************
    public class RGB
    {
        public int indice_canaux = 3;
        public string[] fonction = new string[] { "Rouge", "Vert", "Bleu" };
        public string[] path_image = new string[] { "rouge.bmp", "vert.bmp", "bleu.bmp" };
    }
    public class CYM
    {
        public int indice_canaux = 3;
        public string[] fonction = new string[] { "Cyan", "Magenta", "Yellow" };
        public string[] path_image = new string[] { "cyan.bmp", "magenta.bmp", "yellow.bmp" };
    }
    public class Dimmer
    {
        public int indice_canaux = 1;
        public string[] fonction = new string[] { "Dimmer" };
        public string[] path_image = new string[] { "dimmer.bmp"};
    }
    public class PanTilt
    {
        public int indice_canaux = 2;
        public string[] fonction = new string[] { "PAN", "TILT" };
        public string[] path_image = new string[] { "pan.bmp", "tilt.bmp" };
    }
    public class Gobo
    {
        public int indice_canaux = 1;
        public string[] fonction = new string[] { "Gobo" };
        public string[] path_image = new string[] { "gobo.bmp" };
    }
    public class Color
    {
        public int indice_canaux = 1;
        public string[] fonction = new string[] { "Color" };
        public string[] path_image = new string[] { "color.bmp" };
    }
    public class Undef
    {
        public int indice_canaux = 1;
        public string[] fonction = new string[] { "Undef" };
        public string[] path_image = new string[] { "undef.bmp" };
    }
}
