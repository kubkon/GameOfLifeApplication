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
        private int maxIterations = 200;

        public Form1()
        {
            InitializeComponent();
            
            // Create new instance of the World
            world = new World(10, 10, 50);
        }

        private void runSimulationClick(object sender, EventArgs e)
        {
            world.Randomise();
            var g = simulationPreviewBox.CreateGraphics();
            var font = new Font(this.Font.Name, this.Font.Size);
            world.Evolve();
            g.DrawString(world.ToString(), font, Brushes.Black, 0, 0);
        }
    }
}
