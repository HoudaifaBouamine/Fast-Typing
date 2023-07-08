namespace FastTyping
{
    partial class main
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
            this.ucTypingBoard1 = new WindowsFormsControlLibrary1.ucTypingBoard();
            this.SuspendLayout();
            // 
            // ucTypingBoard1
            // 
            this.ucTypingBoard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ucTypingBoard1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTypingBoard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ucTypingBoard1.Location = new System.Drawing.Point(50, 47);
            this.ucTypingBoard1.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.ucTypingBoard1.Name = "ucTypingBoard1";
            this.ucTypingBoard1.Size = new System.Drawing.Size(969, 191);
            this.ucTypingBoard1.TabIndex = 0;
            this.ucTypingBoard1.Load += new System.EventHandler(this.ucTypingBoard1_Load);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 636);
            this.Controls.Add(this.ucTypingBoard1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary1.ucTypingBoard ucTypingBoard1;
    }
}

