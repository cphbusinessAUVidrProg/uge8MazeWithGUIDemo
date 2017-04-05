namespace WindowsFormsApplication1
{
    partial class MazeForm
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
            this.mazeControl1 = new WindowsFormsApplication1.MazeControl();
            this.SuspendLayout();
            // 
            // mazeControl1
            // 
            this.mazeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mazeControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mazeControl1.Location = new System.Drawing.Point(199, 13);
            this.mazeControl1.Name = "mazeControl1";
            this.mazeControl1.Size = new System.Drawing.Size(791, 782);
            this.mazeControl1.TabIndex = 0;
            this.mazeControl1.Load += new System.EventHandler(this.mazeControl1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 807);
            this.Controls.Add(this.mazeControl1);
            this.Name = "Form1";
            this.Text = "Maze";
            this.ResumeLayout(false);

        }

        #endregion

        private MazeControl mazeControl1;
    }
}

