namespace WindowsFormsControlLibrary1
{
    partial class ucTypingBoard
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
            this.typing_Board = new ColoredLable.ucColoredLabel();
            this.SuspendLayout();
            // 
            // typing_Board
            // 
            this.typing_Board.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.typing_Board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typing_Board.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.typing_Board.Location = new System.Drawing.Point(0, 0);
            this.typing_Board.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typing_Board.Name = "typing_Board";
            this.typing_Board.Size = new System.Drawing.Size(968, 214);
            this.typing_Board.TabIndex = 1;
            this.typing_Board.KeyDown += new System.Windows.Forms.KeyEventHandler(this.typing_Board_KeyDown);
            // 
            // ucTypingBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.typing_Board);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucTypingBoard";
            this.Size = new System.Drawing.Size(968, 214);
            this.Load += new System.EventHandler(this.ucTypingBoard_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.typing_Board_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private ColoredLable.ucColoredLabel typing_Board;
    }
}
