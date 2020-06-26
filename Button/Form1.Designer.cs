namespace Runaway_Button
{
    partial class RunButtonView
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
            this.pushMeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pushMeButton
            // 
            this.pushMeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pushMeButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pushMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pushMeButton.Location = new System.Drawing.Point(420, 251);
            this.pushMeButton.Name = "pushMeButton";
            this.pushMeButton.Size = new System.Drawing.Size(112, 41);
            this.pushMeButton.TabIndex = 0;
            this.pushMeButton.Text = "Push Me";
            this.pushMeButton.UseVisualStyleBackColor = false;
            this.pushMeButton.Click += new System.EventHandler(this.PushMeButton_Click);
            // 
            // runButtonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(959, 561);
            this.Controls.Add(this.pushMeButton);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "runButtonView";
            this.Text = "Runaway Button";
            this.MouseEnter += new System.EventHandler(this.RunButtonView_MouseEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RunButtonView_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pushMeButton;
    }
}

