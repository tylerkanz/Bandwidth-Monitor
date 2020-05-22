namespace Bandwidth_Monitor
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
            this.components = new System.ComponentModel.Container();
            this.lbl_down = new System.Windows.Forms.Label();
            this.lbl_up = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_down
            // 
            this.lbl_down.AutoSize = true;
            this.lbl_down.Location = new System.Drawing.Point(12, 9);
            this.lbl_down.Name = "lbl_down";
            this.lbl_down.Size = new System.Drawing.Size(55, 13);
            this.lbl_down.TabIndex = 0;
            this.lbl_down.Text = "Download";
            // 
            // lbl_up
            // 
            this.lbl_up.AutoSize = true;
            this.lbl_up.Location = new System.Drawing.Point(12, 56);
            this.lbl_up.Name = "lbl_up";
            this.lbl_up.Size = new System.Drawing.Size(41, 13);
            this.lbl_up.TabIndex = 1;
            this.lbl_up.Text = "Upload";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 130);
            this.Controls.Add(this.lbl_up);
            this.Controls.Add(this.lbl_down);
            this.Name = "Form1";
            this.Text = "Bandwidth Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_down;
        private System.Windows.Forms.Label lbl_up;
        private System.Windows.Forms.Timer timer1;
    }
}

