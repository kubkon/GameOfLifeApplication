using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLifeApplication
{
    public partial class Form1 : Form
    {
        private World world = null;
        private Image liveCellImg;

        public Form1()
        {
            InitializeComponent();
            // Load image representing live cell
            liveCellImg = Image.FromFile(@"..\..\assets\live_cell.bmp");
            // Create new instance of the World
            world = new World(10, 10, 50);
        }

        private void runSimulationClick(object sender, EventArgs e)
        {
            world.Randomise();
            var g = simulationPreviewBox.CreateGraphics();
            world.Evolve();
            Image img = Image.FromFile(@"..\..\assets\live_cell.bmp");
            g.DrawImage(img, 0, 0, 10, 10);
        }
    }
}
