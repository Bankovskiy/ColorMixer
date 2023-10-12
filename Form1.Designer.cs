namespace ColorMixerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            redBox = new PictureBox();
            greenBox = new PictureBox();
            blueBox = new PictureBox();
            numericRed = new NumericUpDown();
            numericGreen = new NumericUpDown();
            numericBlue = new NumericUpDown();
            contextMenuStrip1 = new ContextMenuStrip(components);
            teToolStripMenuItem = new ToolStripMenuItem();
            labelRed = new Label();
            labelGreen = new Label();
            labelBlue = new Label();
            labelThatsAColorMixer = new Label();
            ((System.ComponentModel.ISupportInitialize)redBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBlue).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // redBox
            // 
            redBox.BackColor = SystemColors.Control;
            redBox.Location = new Point(10, 75);
            redBox.Name = "redBox";
            redBox.Size = new Size(200, 200);
            redBox.TabIndex = 0;
            redBox.TabStop = false;
            // 
            // greenBox
            // 
            greenBox.BackColor = SystemColors.Control;
            greenBox.Location = new Point(297, 75);
            greenBox.Name = "greenBox";
            greenBox.Size = new Size(200, 200);
            greenBox.TabIndex = 1;
            greenBox.TabStop = false;
            // 
            // blueBox
            // 
            blueBox.BackColor = SystemColors.Control;
            blueBox.Location = new Point(586, 75);
            blueBox.Name = "blueBox";
            blueBox.Size = new Size(200, 200);
            blueBox.TabIndex = 2;
            blueBox.TabStop = false;
            // 
            // numericRed
            // 
            numericRed.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            numericRed.Location = new Point(10, 304);
            numericRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericRed.Name = "numericRed";
            numericRed.Size = new Size(200, 52);
            numericRed.TabIndex = 3;
            numericRed.ValueChanged += numericRed_ValueChanged;
            // 
            // numericGreen
            // 
            numericGreen.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            numericGreen.Location = new Point(297, 304);
            numericGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericGreen.Name = "numericGreen";
            numericGreen.Size = new Size(200, 52);
            numericGreen.TabIndex = 4;
            numericGreen.ValueChanged += numericGreen_ValueChanged;
            // 
            // numericBlue
            // 
            numericBlue.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            numericBlue.Location = new Point(586, 304);
            numericBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericBlue.Name = "numericBlue";
            numericBlue.Size = new Size(200, 52);
            numericBlue.TabIndex = 5;
            numericBlue.ValueChanged += numericBlue_ValueChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { teToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(85, 26);
            // 
            // teToolStripMenuItem
            // 
            teToolStripMenuItem.Name = "teToolStripMenuItem";
            teToolStripMenuItem.Size = new Size(84, 22);
            teToolStripMenuItem.Text = "te";
            // 
            // labelRed
            // 
            labelRed.AutoSize = true;
            labelRed.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            labelRed.Location = new Point(62, 26);
            labelRed.Name = "labelRed";
            labelRed.Size = new Size(77, 46);
            labelRed.TabIndex = 7;
            labelRed.Text = "Red";
            // 
            // labelGreen
            // 
            labelGreen.AutoSize = true;
            labelGreen.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            labelGreen.Location = new Point(337, 26);
            labelGreen.Name = "labelGreen";
            labelGreen.Size = new Size(110, 46);
            labelGreen.TabIndex = 8;
            labelGreen.Text = "Green";
            labelGreen.Click += labelGreen_Click;
            // 
            // labelBlue
            // 
            labelBlue.AutoSize = true;
            labelBlue.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            labelBlue.Location = new Point(644, 26);
            labelBlue.Name = "labelBlue";
            labelBlue.Size = new Size(84, 46);
            labelBlue.TabIndex = 9;
            labelBlue.Text = "Blue";
            // 
            // labelThatsAColorMixer
            // 
            labelThatsAColorMixer.AutoSize = true;
            labelThatsAColorMixer.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            labelThatsAColorMixer.Location = new Point(135, 380);
            labelThatsAColorMixer.Name = "labelThatsAColorMixer";
            labelThatsAColorMixer.Size = new Size(489, 46);
            labelThatsAColorMixer.TabIndex = 10;
            labelThatsAColorMixer.Text = "AND THAT'S A COLOR MIXER!!!";
            labelThatsAColorMixer.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelThatsAColorMixer);
            Controls.Add(labelBlue);
            Controls.Add(labelGreen);
            Controls.Add(labelRed);
            Controls.Add(numericBlue);
            Controls.Add(numericGreen);
            Controls.Add(numericRed);
            Controls.Add(blueBox);
            Controls.Add(greenBox);
            Controls.Add(redBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)redBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBlue).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox redBox;
        private PictureBox greenBox;
        private PictureBox blueBox;
        private NumericUpDown numericRed;
        private NumericUpDown numericGreen;
        private NumericUpDown numericBlue;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem teToolStripMenuItem;
        private Label labelRed;
        private Label labelGreen;
        private Label labelBlue;
        private Label labelThatsAColorMixer;
    }
}