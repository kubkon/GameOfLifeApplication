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
        private World world;
        private Image liveCellImg;
        private Size cellSize;
        private Image canvas;
        private Graphics graphics;

        public int maxIterations = 200;
        public int rows = 20;
        public int columns = 20;
        public int initLiveCells = 150;

        public Form1()
        {
            InitializeComponent();
            // Load images representing live cell
            liveCellImg = Image.FromFile(@"..\..\assets\live_cell.bmp");
            // Specify cell size
            cellSize = new Size(10, 10);
            // Create master canvas
            canvas = new Bitmap(rows * cellSize.Width, columns * cellSize.Height);
            // Create new instance of the World
            world = new World(rows, columns, initLiveCells);
        }

        private void drawWorld()
        {
            var child = Graphics.FromImage(canvas);
            child.Clear(Color.White);
            for (int i = 0; i < world.rows; i++)
            {
                for (int j = 0; j < world.columns; j++)
                {
                    var location = new Point(i * cellSize.Width, j * cellSize.Height);
                    if (world.grid[i, j] == World.State.Live)
                        child.DrawImage(liveCellImg, new Rectangle(location, cellSize));
                }
            }
            if (graphics == null)
                graphics = simulationPreviewBox.CreateGraphics();
            graphics.DrawImage(canvas, 0, 0);
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
