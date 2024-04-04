namespace WF_WPF_04._TrackBar
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
            trackBar1 = new TrackBar();
            label1 = new Label();
            redTrackBar = new TrackBar();
            greenTrackBar = new TrackBar();
            blueTrackBar = new TrackBar();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueTrackBar).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(45, 30);
            trackBar1.Maximum = 50;
            trackBar1.Minimum = 9;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(248, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 9;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(397, 40);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Salam";
            // 
            // redTrackBar
            // 
            redTrackBar.Location = new Point(45, 191);
            redTrackBar.Maximum = 255;
            redTrackBar.Name = "redTrackBar";
            redTrackBar.Size = new Size(248, 45);
            redTrackBar.TabIndex = 2;
            redTrackBar.Scroll += TrackBarChange;
            // 
            // greenTrackBar
            // 
            greenTrackBar.Location = new Point(45, 242);
            greenTrackBar.Maximum = 255;
            greenTrackBar.Name = "greenTrackBar";
            greenTrackBar.Size = new Size(248, 45);
            greenTrackBar.TabIndex = 2;
            greenTrackBar.Scroll += TrackBarChange;
            // 
            // blueTrackBar
            // 
            blueTrackBar.Location = new Point(45, 293);
            blueTrackBar.Maximum = 255;
            blueTrackBar.Name = "blueTrackBar";
            blueTrackBar.Size = new Size(248, 45);
            blueTrackBar.TabIndex = 2;
            blueTrackBar.Scroll += TrackBarChange;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 202);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Red:  0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 254);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 3;
            label3.Text = "Green:  0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(308, 302);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Blue:  0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(blueTrackBar);
            Controls.Add(greenTrackBar);
            Controls.Add(redTrackBar);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)redTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private Label label1;
        private TrackBar redTrackBar;
        private TrackBar greenTrackBar;
        private TrackBar blueTrackBar;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}