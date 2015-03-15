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

        private int rows;
        private int columns;
        private int initLiveCells;
        private int maxIterations;

        public Form1()
        {
            InitializeComponent();
            // Load images representing live cell
            liveCellImg = Image.FromFile(@"..\..\assets\live_cell.bmp");
            // Specify cell size
            cellSize = new Size(10, 10);
            // Create master canvas
            canvas = new Bitmap(simulationPreviewBox.Width, simulationPreviewBox.Height);
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
            // FIX:ME if size of the world smaller than max, draw in the centre of the picture box
            graphics.DrawImage(canvas, 0, 0);
        }

        private async Task runSimulation()
        {
            world.Randomise();
            for (int i = 0; i < maxIterations; i++)
            {
                drawWorld();
                if (world.Evolve())
                    break;
            }
        }

        private bool checkAndParseInput()
        {
            var maxRows = simulationPreviewBox.Width / 10;
            if (!Int32.TryParse(rowsTextBox.Text, out rows) || rows == 0 || rows > maxRows)
            {
                var msg = String.Format("Number of rows has to be greater than 0 and smaller than {0}.", maxRows);
                MessageBox.Show(msg);
                return false;
            }

            var maxColumns = simulationPreviewBox.Height / 10;
            if (!Int32.TryParse(columnsTextBox.Text, out columns) || columns == 0 || columns > maxColumns)
            {
                var msg = String.Format("Number of columns has to be greater than 0 and smaller than {0}.", maxColumns);
                MessageBox.Show(msg);
                return false;
            }

            var maxInitLiveCells = rows * columns;
            if (!Int32.TryParse(initCellsTextBox.Text, out initLiveCells)
                || initLiveCells == 0
                || initLiveCells > maxInitLiveCells)
            {
                var msg = String.Format("Initial number of live cells has to be greater than 0 and smaller than {0}.", maxInitLiveCells);
                MessageBox.Show(msg);
                return false;
            }

            if (!Int32.TryParse(maxIterationsTextBox.Text, out maxIterations) || maxIterations == 0)
            {
                var msg = String.Format("Maximum number of iterations has to be greater than 0.");
                MessageBox.Show(msg);
                return false;
            }

            return true;
        }

        private async void runSimulation_Click(object sender, EventArgs e)
        {
            if (checkAndParseInput())
            {
                // Create new instance of the World
                world = new World(rows, columns, initLiveCells);
                await Task.Run(() => runSimulation());
            }
        }

        private void CheckKeys(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                runSimulation_Click(sender, e);
            else
            {
                if (char.IsLetter(e.KeyChar) ||
                    char.IsSymbol(e.KeyChar) ||
                    char.IsWhiteSpace(e.KeyChar) ||
                    char.IsPunctuation(e.KeyChar))
                    e.Handled = true;
            }
        }
    }
}
