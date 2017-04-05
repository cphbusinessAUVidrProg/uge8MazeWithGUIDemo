namespace WindowsFormsApplication1
{
    partial class MazeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MazeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MazeControl";
            this.Size = new System.Drawing.Size(368, 334);
            this.Load += new System.EventHandler(this.MazeControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintMe);
            this.Resize += new System.EventHandler(this.MazeControl_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
