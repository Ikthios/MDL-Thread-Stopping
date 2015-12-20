namespace UserControl
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
            this.Btn_StartThread = new System.Windows.Forms.Button();
            this.Btn_StopThread = new System.Windows.Forms.Button();
            this.Txt_Results = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_StartThread
            // 
            this.Btn_StartThread.Location = new System.Drawing.Point(12, 12);
            this.Btn_StartThread.Name = "Btn_StartThread";
            this.Btn_StartThread.Size = new System.Drawing.Size(75, 23);
            this.Btn_StartThread.TabIndex = 0;
            this.Btn_StartThread.Text = "Start";
            this.Btn_StartThread.UseVisualStyleBackColor = true;
            this.Btn_StartThread.Click += new System.EventHandler(this.Btn_StartThread_Click);
            // 
            // Btn_StopThread
            // 
            this.Btn_StopThread.Location = new System.Drawing.Point(12, 41);
            this.Btn_StopThread.Name = "Btn_StopThread";
            this.Btn_StopThread.Size = new System.Drawing.Size(75, 23);
            this.Btn_StopThread.TabIndex = 1;
            this.Btn_StopThread.Text = "Stop";
            this.Btn_StopThread.UseVisualStyleBackColor = true;
            this.Btn_StopThread.Click += new System.EventHandler(this.Btn_StopThread_Click);
            // 
            // Txt_Results
            // 
            this.Txt_Results.Location = new System.Drawing.Point(12, 70);
            this.Txt_Results.Multiline = true;
            this.Txt_Results.Name = "Txt_Results";
            this.Txt_Results.ReadOnly = true;
            this.Txt_Results.Size = new System.Drawing.Size(260, 179);
            this.Txt_Results.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Txt_Results);
            this.Controls.Add(this.Btn_StopThread);
            this.Controls.Add(this.Btn_StartThread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_StartThread;
        private System.Windows.Forms.Button Btn_StopThread;
        private System.Windows.Forms.TextBox Txt_Results;
    }
}

