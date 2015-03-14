using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLifeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runSimulationClick(object sender, EventArgs e)
        {
            var rec = new Rectangle(10, 10, 20, 20);
            var pen = new Pen(Brushes.Black);
            var g = this.simulationPreviewBox.CreateGraphics();
            g.DrawRectangle(pen, rec);
        }
    }
}
