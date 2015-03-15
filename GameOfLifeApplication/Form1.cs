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
        private Image deadCellImg;
        private Size cellSize;
        private int maxIterations = 200;
        private int rows = 20;
        private int columns = 20;
        private int initLiveCells = 200;

        public Form1()
        {
            InitializeComponent();
            // Load images representing live and dead cell
            liveCellImg = Image.FromFile(@"..\..\assets\live_cell.bmp");
            deadCellImg = Image.FromFile(@"..\..\assets\dead_cell.bmp");
            cellSize = new Size(10, 10);
            // Create new instance of the World
            world = new World(rows, columns, initLiveCells);
        }

        private void drawWorld()
        {
            var g = simulationPreviewBox.CreateGraphics();
            for (int i = 0; i < world.rows; i++)
            {
                for (int j = 0; j < world.columns; j++)
                {
                    var location = new Point(i*cellSize.Height, j*cellSize.Width);
                    if (world.grid[i, j] == World.State.Live)
                        g.DrawImage(liveCellImg, new Rectangle(location, cellSize));
                    else
                        g.DrawImage(deadCellImg, new Rectangle(location, cellSize));
                }
            }
        }

        private void runSimulationClick(object sender, EventArgs e)
        {
            world.Randomise();
            for (int i = 0; i < maxIterations; i++)
            {
                drawWorld();
                if (world.Evolve())
                    break;
            }
        }
    }
}
