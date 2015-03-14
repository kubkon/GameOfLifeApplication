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
            ((System.ComponentModel.ISupportInitialize)(this.simulationPreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // runSimulation
            // 
            this.runSimulation.Location = new System.Drawing.Point(200, 400);
            this.runSimulation.Name = "runSimulation";
            this.runSimulation.Size = new System.Drawing.Size(100, 35);
            this.runSimulation.TabIndex = 0;
            this.runSimulation.Text = "Run simulation";
            this.runSimulation.UseVisualStyleBackColor = true;
            this.runSimulation.Click += new System.EventHandler(this.runSimulationClick);
            // 
            // simulationPreviewBox
            // 
            this.simulationPreviewBox.Location = new System.Drawing.Point(25, 25);
            this.simulationPreviewBox.Name = "simulationPreviewBox";
            this.simulationPreviewBox.Size = new System.Drawing.Size(425, 350);
            this.simulationPreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.simulationPreviewBox.TabIndex = 1;
            this.simulationPreviewBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
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
    }
}

