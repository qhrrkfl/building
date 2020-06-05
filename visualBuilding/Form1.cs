using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace visualBuilding
{
    public class building
    {
        public Point p;
        public Size size;
        public Rectangle dRect;
        public Rectangle hRect;
        public Point[] line = new Point[2];


    }

    public partial class Form1 : Form
    {
        int numOfBuildings;
        public Form1()
        {
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            // If there is an image and it has a location, 
            // paint it when the Form is repainted.
            base.OnPaint(e);
            var g = e.Graphics;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader fs = new StreamReader("input.txt");
            numOfBuildings = int.Parse(fs.ReadLine());
            var buildHeight = fs.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            int interval = 50;
            int size = 
            buildHeight.Select(x=> 
            {
                building b = new building();

            })
        }
    }


}

   
