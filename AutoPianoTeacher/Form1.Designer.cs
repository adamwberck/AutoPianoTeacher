
namespace AutoPianoTeacher
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
            this.canvasControl1 = new AutoPianoTeacher.CanvasControl();
            this.SuspendLayout();
            // 
            // canvasControl1
            // 
            this.canvasControl1.Location = new System.Drawing.Point(12, 12);
            this.canvasControl1.Name = "canvasControl1";
            this.canvasControl1.Size = new System.Drawing.Size(269, 147);
            this.canvasControl1.TabIndex = 0;
            this.canvasControl1.Text = "canvasControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(293, 171);
            this.Controls.Add(this.canvasControl1);
            this.Name = "Form1";
            this.Text = "PianoTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CanvasControl canvasControl1;
    }
}

