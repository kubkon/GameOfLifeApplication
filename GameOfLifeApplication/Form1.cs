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

        private int maxIterations;
        private int rows;
        private int columns;
        private int initLiveCells;

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
            graphics.DrawImage(canvas,
                               (simulationPreviewBox.Width - rows * cellSize.Width) / 2,
                               (simulationPreviewBox.Height - columns * cellSize.Height) / 2);
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

        private async void runSimulation_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(rowsTextBox.Text, out rows))
                rows = simulationPreviewBox.Width / 10;
            if (!Int32.TryParse(columnsTextBox.Text, out columns))
                columns = simulationPreviewBox.Height / 10;
            if (!Int32.TryParse(initCellsTextBox.Text, out initLiveCells))
                initLiveCells = (rows * columns) / 2;
            if (!Int32.TryParse(maxIterationsTextBox.Text, out maxIterations))
                maxIterations = 200;
            // Create new instance of the World
            world = new World(rows, columns, initLiveCells);
            await Task.Run(() => runSimulation());
        }

        private bool IsNumber(char c)
        {
            return !(char.IsLetter(c) || char.IsSymbol(c) || char.IsWhiteSpace(c) || char.IsPunctuation(c));
        }

        private void rowsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void columnsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void initCellsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void maxIterationsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsNumber(e.KeyChar))
                e.Handled = true;
        } 
    }
}
