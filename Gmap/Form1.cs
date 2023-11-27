using GMap.NET.MapProviders;
using System;
using System.Windows.Forms;

namespace Gmap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(textBox2.Text);
            double lng = Convert.ToDouble(textBox1.Text);
            gMapControl1.Position = new GMap.NET.PointLatLng(lat, lng);
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 50;
            gMapControl1.Zoom = 15;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}