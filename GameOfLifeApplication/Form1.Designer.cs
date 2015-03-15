﻿namespace GameOfLifeApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.runSimulation = new System.Windows.Forms.Button();
            this.simulationPreviewBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rowsLabel = new System.Windows.Forms.Label();
            this.columnsLabel = new System.Windows.Forms.Label();
            this.initCellLabel = new System.Windows.Forms.Label();
            this.rowsTextBox = new System.Windows.Forms.TextBox();
            this.columnsTextBox = new System.Windows.Forms.TextBox();
            this.initCellsTextBox = new System.Windows.Forms.TextBox();
            this.maxIterationsLabel = new System.Windows.Forms.Label();
            this.maxIterationsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.simulationPreviewBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // runSimulation
            // 
            this.runSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.runSimulation.Location = new System.Drawing.Point(586, 477);
            this.runSimulation.Name = "runSimulation";
            this.runSimulation.Size = new System.Drawing.Size(100, 35);
            this.runSimulation.TabIndex = 0;
            this.runSimulation.Text = "Run simulation";
            this.runSimulation.UseVisualStyleBackColor = true;
            this.runSimulation.Click += new System.EventHandler(this.runSimulationClick);
            // 
            // simulationPreviewBox
            // 
            this.simulationPreviewBox.Location = new System.Drawing.Point(12, 12);
            this.simulationPreviewBox.Name = "simulationPreviewBox";
            this.simulationPreviewBox.Size = new System.Drawing.Size(500, 500);
            this.simulationPreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.simulationPreviewBox.TabIndex = 1;
            this.simulationPreviewBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.maxIterationsTextBox);
            this.groupBox1.Controls.Add(this.maxIterationsLabel);
            this.groupBox1.Controls.Add(this.initCellsTextBox);
            this.groupBox1.Controls.Add(this.columnsTextBox);
            this.groupBox1.Controls.Add(this.rowsTextBox);
            this.groupBox1.Controls.Add(this.initCellLabel);
            this.groupBox1.Controls.Add(this.columnsLabel);
            this.groupBox1.Controls.Add(this.rowsLabel);
            this.groupBox1.Location = new System.Drawing.Point(518, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 459);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulation parameters";
            // 
            // rowsLabel
            // 
            this.rowsLabel.AutoSize = true;
            this.rowsLabel.Location = new System.Drawing.Point(42, 37);
            this.rowsLabel.Name = "rowsLabel";
            this.rowsLabel.Size = new System.Drawing.Size(37, 13);
            this.rowsLabel.TabIndex = 0;
            this.rowsLabel.Text = "Rows:";
            // 
            // columnsLabel
            // 
            this.columnsLabel.AutoSize = true;
            this.columnsLabel.Location = new System.Drawing.Point(29, 74);
            this.columnsLabel.Name = "columnsLabel";
            this.columnsLabel.Size = new System.Drawing.Size(50, 13);
            this.columnsLabel.TabIndex = 1;
            this.columnsLabel.Text = "Columns:";
            // 
            // initCellLabel
            // 
            this.initCellLabel.AutoSize = true;
            this.initCellLabel.Location = new System.Drawing.Point(33, 112);
            this.initCellLabel.Name = "initCellLabel";
            this.initCellLabel.Size = new System.Drawing.Size(46, 13);
            this.initCellLabel.TabIndex = 2;
            this.initCellLabel.Text = "InitCells:";
            // 
            // rowsTextBox
            // 
            this.rowsTextBox.Location = new System.Drawing.Point(85, 34);
            this.rowsTextBox.MaxLength = 10;
            this.rowsTextBox.Name = "rowsTextBox";
            this.rowsTextBox.Size = new System.Drawing.Size(100, 20);
            this.rowsTextBox.TabIndex = 3;
            // 
            // columnsTextBox
            // 
            this.columnsTextBox.Location = new System.Drawing.Point(85, 71);
            this.columnsTextBox.MaxLength = 10;
            this.columnsTextBox.Name = "columnsTextBox";
            this.columnsTextBox.Size = new System.Drawing.Size(100, 20);
            this.columnsTextBox.TabIndex = 4;
            // 
            // initCellsTextBox
            // 
            this.initCellsTextBox.Location = new System.Drawing.Point(85, 109);
            this.initCellsTextBox.MaxLength = 10;
            this.initCellsTextBox.Name = "initCellsTextBox";
            this.initCellsTextBox.Size = new System.Drawing.Size(100, 20);
            this.initCellsTextBox.TabIndex = 5;
            // 
            // maxIterationsLabel
            // 
            this.maxIterationsLabel.AutoSize = true;
            this.maxIterationsLabel.Location = new System.Drawing.Point(6, 149);
            this.maxIterationsLabel.Name = "maxIterationsLabel";
            this.maxIterationsLabel.Size = new System.Drawing.Size(73, 13);
            this.maxIterationsLabel.TabIndex = 6;
            this.maxIterationsLabel.Text = "MaxIterations:";
            // 
            // maxIterationsTextBox
            // 
            this.maxIterationsTextBox.Location = new System.Drawing.Point(85, 146);
            this.maxIterationsTextBox.MaxLength = 10;
            this.maxIterationsTextBox.Name = "maxIterationsTextBox";
            this.maxIterationsTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxIterationsTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simulationPreviewBox);
            this.Controls.Add(this.runSimulation);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.simulationPreviewBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runSimulation;
        private System.Windows.Forms.PictureBox simulationPreviewBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox initCellsTextBox;
        private System.Windows.Forms.TextBox columnsTextBox;
        private System.Windows.Forms.TextBox rowsTextBox;
        private System.Windows.Forms.Label initCellLabel;
        private System.Windows.Forms.Label columnsLabel;
        private System.Windows.Forms.Label rowsLabel;
        private System.Windows.Forms.TextBox maxIterationsTextBox;
        private System.Windows.Forms.Label maxIterationsLabel;
    }
}

