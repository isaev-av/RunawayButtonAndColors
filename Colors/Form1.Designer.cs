namespace Color_Palette
{
    partial class ColorForm
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
            System.Windows.Forms.Label red;
            System.Windows.Forms.Label green;
            System.Windows.Forms.Label blue;
            System.Windows.Forms.Label minValueRed;
            System.Windows.Forms.Label minValueGreen;
            System.Windows.Forms.Label minValueBlue;
            System.Windows.Forms.Label maxValueRed;
            System.Windows.Forms.Label maxValueGreen;
            System.Windows.Forms.Label maxValueBlue;
            this.redTrack = new System.Windows.Forms.TrackBar();
            this.greenTrack = new System.Windows.Forms.TrackBar();
            this.blueTrack = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.colorOutput = new System.Windows.Forms.Panel();
            red = new System.Windows.Forms.Label();
            green = new System.Windows.Forms.Label();
            blue = new System.Windows.Forms.Label();
            minValueRed = new System.Windows.Forms.Label();
            minValueGreen = new System.Windows.Forms.Label();
            minValueBlue = new System.Windows.Forms.Label();
            maxValueRed = new System.Windows.Forms.Label();
            maxValueGreen = new System.Windows.Forms.Label();
            maxValueBlue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.redTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrack)).BeginInit();
            this.colorOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // red
            // 
            red.Anchor = System.Windows.Forms.AnchorStyles.Right;
            red.AutoSize = true;
            red.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            red.ForeColor = System.Drawing.Color.Black;
            red.Location = new System.Drawing.Point(354, 40);
            red.Name = "red";
            red.Size = new System.Drawing.Size(43, 20);
            red.TabIndex = 5;
            red.Text = "Red:";
            // 
            // green
            // 
            green.Anchor = System.Windows.Forms.AnchorStyles.Right;
            green.AutoSize = true;
            green.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            green.ForeColor = System.Drawing.Color.Black;
            green.Location = new System.Drawing.Point(354, 97);
            green.Name = "green";
            green.Size = new System.Drawing.Size(58, 20);
            green.TabIndex = 6;
            green.Text = "Green:";
            // 
            // blue
            // 
            blue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            blue.AutoSize = true;
            blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            blue.ForeColor = System.Drawing.Color.Black;
            blue.Location = new System.Drawing.Point(354, 156);
            blue.Name = "blue";
            blue.Size = new System.Drawing.Size(45, 20);
            blue.TabIndex = 7;
            blue.Text = "Blue:";
            // 
            // minValueRed
            // 
            minValueRed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            minValueRed.AutoSize = true;
            minValueRed.BackColor = System.Drawing.SystemColors.Control;
            minValueRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            minValueRed.Location = new System.Drawing.Point(423, 68);
            minValueRed.Name = "minValueRed";
            minValueRed.Size = new System.Drawing.Size(16, 17);
            minValueRed.TabIndex = 8;
            minValueRed.Text = "0";
            // 
            // minValueGreen
            // 
            minValueGreen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            minValueGreen.AutoSize = true;
            minValueGreen.BackColor = System.Drawing.SystemColors.Control;
            minValueGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            minValueGreen.Location = new System.Drawing.Point(423, 136);
            minValueGreen.Name = "minValueGreen";
            minValueGreen.Size = new System.Drawing.Size(16, 17);
            minValueGreen.TabIndex = 9;
            minValueGreen.Text = "0";
            // 
            // minValueBlue
            // 
            minValueBlue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            minValueBlue.AutoSize = true;
            minValueBlue.BackColor = System.Drawing.SystemColors.Control;
            minValueBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            minValueBlue.Location = new System.Drawing.Point(423, 184);
            minValueBlue.Name = "minValueBlue";
            minValueBlue.Size = new System.Drawing.Size(16, 17);
            minValueBlue.TabIndex = 10;
            minValueBlue.Text = "0";
            // 
            // maxValueRed
            // 
            maxValueRed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            maxValueRed.AutoSize = true;
            maxValueRed.BackColor = System.Drawing.SystemColors.Control;
            maxValueRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            maxValueRed.Location = new System.Drawing.Point(586, 68);
            maxValueRed.Name = "maxValueRed";
            maxValueRed.Size = new System.Drawing.Size(32, 17);
            maxValueRed.TabIndex = 11;
            maxValueRed.Text = "255";
            // 
            // maxValueGreen
            // 
            maxValueGreen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            maxValueGreen.AutoSize = true;
            maxValueGreen.BackColor = System.Drawing.SystemColors.Control;
            maxValueGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            maxValueGreen.Location = new System.Drawing.Point(586, 136);
            maxValueGreen.Name = "maxValueGreen";
            maxValueGreen.Size = new System.Drawing.Size(32, 17);
            maxValueGreen.TabIndex = 12;
            maxValueGreen.Text = "255";
            // 
            // maxValueBlue
            // 
            maxValueBlue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            maxValueBlue.AutoSize = true;
            maxValueBlue.BackColor = System.Drawing.SystemColors.Control;
            maxValueBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            maxValueBlue.Location = new System.Drawing.Point(586, 184);
            maxValueBlue.Name = "maxValueBlue";
            maxValueBlue.Size = new System.Drawing.Size(32, 17);
            maxValueBlue.TabIndex = 13;
            maxValueBlue.Text = "255";
            // 
            // redTrack
            // 
            this.redTrack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.redTrack.BackColor = System.Drawing.SystemColors.Control;
            this.redTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redTrack.Location = new System.Drawing.Point(418, 40);
            this.redTrack.Maximum = 255;
            this.redTrack.Name = "redTrack";
            this.redTrack.Size = new System.Drawing.Size(200, 45);
            this.redTrack.TabIndex = 2;
            this.redTrack.TickFrequency = 25;
            this.redTrack.Value = 125;
            this.redTrack.Scroll += new System.EventHandler(this.ColorTrack_Scroll);
            // 
            // greenTrack
            // 
            this.greenTrack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.greenTrack.BackColor = System.Drawing.SystemColors.Control;
            this.greenTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greenTrack.Location = new System.Drawing.Point(418, 97);
            this.greenTrack.Maximum = 255;
            this.greenTrack.Name = "greenTrack";
            this.greenTrack.Size = new System.Drawing.Size(200, 45);
            this.greenTrack.TabIndex = 3;
            this.greenTrack.TickFrequency = 25;
            this.greenTrack.Value = 125;
            this.greenTrack.Scroll += new System.EventHandler(this.ColorTrack_Scroll);
            // 
            // blueTrack
            // 
            this.blueTrack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.blueTrack.BackColor = System.Drawing.SystemColors.Control;
            this.blueTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueTrack.Location = new System.Drawing.Point(418, 156);
            this.blueTrack.Maximum = 255;
            this.blueTrack.Name = "blueTrack";
            this.blueTrack.Size = new System.Drawing.Size(200, 45);
            this.blueTrack.TabIndex = 4;
            this.blueTrack.TickFrequency = 25;
            this.blueTrack.Value = 125;
            this.blueTrack.Scroll += new System.EventHandler(this.ColorTrack_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(187, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 14;
            this.label1.Visible = false;
            // 
            // colorOutput
            // 
            this.colorOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorOutput.Controls.Add(this.label1);
            this.colorOutput.ForeColor = System.Drawing.SystemColors.MenuText;
            this.colorOutput.Location = new System.Drawing.Point(28, 31);
            this.colorOutput.Name = "colorOutput";
            this.colorOutput.Size = new System.Drawing.Size(284, 170);
            this.colorOutput.TabIndex = 0;
            this.colorOutput.BackColorChanged += new System.EventHandler(this.Color_BackColorChanged);
            this.colorOutput.MouseLeave += new System.EventHandler(this.Color_MouseLeave);
            this.colorOutput.MouseHover += new System.EventHandler(this.Color_MouseHover);
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 249);
            this.Controls.Add(maxValueBlue);
            this.Controls.Add(maxValueGreen);
            this.Controls.Add(maxValueRed);
            this.Controls.Add(minValueBlue);
            this.Controls.Add(minValueGreen);
            this.Controls.Add(minValueRed);
            this.Controls.Add(blue);
            this.Controls.Add(green);
            this.Controls.Add(red);
            this.Controls.Add(this.blueTrack);
            this.Controls.Add(this.greenTrack);
            this.Controls.Add(this.redTrack);
            this.Controls.Add(this.colorOutput);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "ColorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Pallete";
            ((System.ComponentModel.ISupportInitialize)(this.redTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrack)).EndInit();
            this.colorOutput.ResumeLayout(false);
            this.colorOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar redTrack;
        private System.Windows.Forms.TrackBar greenTrack;
        private System.Windows.Forms.TrackBar blueTrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel colorOutput;
    }
}

