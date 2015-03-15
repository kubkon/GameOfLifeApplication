namespace GameOfLifeApplication
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
            ((System.ComponentModel.ISupportInitialize)(this.simulationPreviewBox)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(526, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 459);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulation parameters";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runSimulation;
        private System.Windows.Forms.PictureBox simulationPreviewBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

