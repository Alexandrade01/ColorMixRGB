using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MixerCores
{
    public partial class Form1:MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changecolor(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(TrackRed.Value,TrackGreen.Value,TrackBlue.Value);
            Labelred.Text = TrackRed.Value.ToString();
            Labelgreen.Text = TrackGreen.Value.ToString();
            Labelblue.Text = TrackBlue.Value.ToString();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
