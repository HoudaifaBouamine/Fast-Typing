namespace FastTyping
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
            this.timer_WPS = new System.Windows.Forms.Timer(this.components);
            this.lbl_time_left = new System.Windows.Forms.Label();
            this.btn_Start_Or_Reset = new System.Windows.Forms.Button();
            this.check_if_first_click = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.typingBoard = new WindowsFormsControlLibrary1.ucTypingBoard();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Graph = new ucGraphDrawer.usGraph();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_consistency = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_characters = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_raw = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_acc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_wpm = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_WPS
            // 
            this.timer_WPS.Interval = 1000;
            this.timer_WPS.Tick += new System.EventHandler(this.timer_WPS_Tick);
            // 
            // lbl_time_left
            // 
            this.lbl_time_left.AutoSize = true;
            this.lbl_time_left.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_time_left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(171)))), ((int)(((byte)(23)))));
            this.lbl_time_left.Location = new System.Drawing.Point(89, 45);
            this.lbl_time_left.Name = "lbl_time_left";
            this.lbl_time_left.Size = new System.Drawing.Size(49, 38);
            this.lbl_time_left.TabIndex = 1;
            this.lbl_time_left.Text = "30";
            // 
            // btn_Start_Or_Reset
            // 
            this.btn_Start_Or_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start_Or_Reset.Location = new System.Drawing.Point(549, 366);
            this.btn_Start_Or_Reset.Name = "btn_Start_Or_Reset";
            this.btn_Start_Or_Reset.Size = new System.Drawing.Size(145, 58);
            this.btn_Start_Or_Reset.TabIndex = 2;
            this.btn_Start_Or_Reset.Text = "Start";
            this.btn_Start_Or_Reset.UseVisualStyleBackColor = true;
            this.btn_Start_Or_Reset.Visible = false;
            this.btn_Start_Or_Reset.Click += new System.EventHandler(this.btn_Start_Or_Reset_Click);
            // 
            // check_if_first_click
            // 
            this.check_if_first_click.Enabled = true;
            this.check_if_first_click.Tick += new System.EventHandler(this.check_if_first_click_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.typingBoard);
            this.panel1.Controls.Add(this.btn_Start_Or_Reset);
            this.panel1.Controls.Add(this.lbl_time_left);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 573);
            this.panel1.TabIndex = 3;
            // 
            // typingBoard
            // 
            this.typingBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.typingBoard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typingBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.typingBoard.Location = new System.Drawing.Point(96, 88);
            this.typingBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typingBoard.Name = "typingBoard";
            this.typingBoard.Size = new System.Drawing.Size(1056, 270);
            this.typingBoard.TabIndex = 3;
            this.typingBoard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.Graph);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lbl_time);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lbl_consistency);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbl_characters);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbl_raw);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_acc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_wpm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, -464);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1292, 573);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Graph
            // 
            this.Graph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.Graph.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Graph.Location = new System.Drawing.Point(262, 82);
            this.Graph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(981, 232);
            this.Graph.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label11.Location = new System.Drawing.Point(1124, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 30);
            this.label11.TabIndex = 11;
            this.label11.Text = "time";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI Semibold", 20.2F, System.Drawing.FontStyle.Bold);
            this.lbl_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.lbl_time.Location = new System.Drawing.Point(1121, 405);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(73, 46);
            this.lbl_time.TabIndex = 12;
            this.lbl_time.Text = "30s";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label9.Location = new System.Drawing.Point(867, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 30);
            this.label9.TabIndex = 9;
            this.label9.Text = "consistency";
            // 
            // lbl_consistency
            // 
            this.lbl_consistency.AutoSize = true;
            this.lbl_consistency.Font = new System.Drawing.Font("Segoe UI Semibold", 20.2F, System.Drawing.FontStyle.Bold);
            this.lbl_consistency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.lbl_consistency.Location = new System.Drawing.Point(864, 405);
            this.lbl_consistency.Name = "lbl_consistency";
            this.lbl_consistency.Size = new System.Drawing.Size(82, 46);
            this.lbl_consistency.TabIndex = 10;
            this.lbl_consistency.Text = "51%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label7.Location = new System.Drawing.Point(610, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 30);
            this.label7.TabIndex = 7;
            this.label7.Text = "characters";
            // 
            // lbl_characters
            // 
            this.lbl_characters.AutoSize = true;
            this.lbl_characters.Font = new System.Drawing.Font("Segoe UI Semibold", 20.2F, System.Drawing.FontStyle.Bold);
            this.lbl_characters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.lbl_characters.Location = new System.Drawing.Point(607, 405);
            this.lbl_characters.Name = "lbl_characters";
            this.lbl_characters.Size = new System.Drawing.Size(157, 46);
            this.lbl_characters.TabIndex = 8;
            this.lbl_characters.Text = "60/0/0/0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label5.Location = new System.Drawing.Point(353, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "raw";
            // 
            // lbl_raw
            // 
            this.lbl_raw.AutoSize = true;
            this.lbl_raw.Font = new System.Drawing.Font("Segoe UI Semibold", 20.2F, System.Drawing.FontStyle.Bold);
            this.lbl_raw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.lbl_raw.Location = new System.Drawing.Point(350, 405);
            this.lbl_raw.Name = "lbl_raw";
            this.lbl_raw.Size = new System.Drawing.Size(59, 46);
            this.lbl_raw.TabIndex = 6;
            this.lbl_raw.Text = "48";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(41, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "acc";
            // 
            // lbl_acc
            // 
            this.lbl_acc.AutoSize = true;
            this.lbl_acc.Font = new System.Drawing.Font("Segoe UI Semibold", 45.2F, System.Drawing.FontStyle.Bold);
            this.lbl_acc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.lbl_acc.Location = new System.Drawing.Point(33, 261);
            this.lbl_acc.Name = "lbl_acc";
            this.lbl_acc.Size = new System.Drawing.Size(190, 101);
            this.lbl_acc.TabIndex = 3;
            this.lbl_acc.Text = "97%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(106)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(41, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "wpm";
            // 
            // lbl_wpm
            // 
            this.lbl_wpm.AutoSize = true;
            this.lbl_wpm.Font = new System.Drawing.Font("Segoe UI Semibold", 45.2F, System.Drawing.FontStyle.Bold);
            this.lbl_wpm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.lbl_wpm.Location = new System.Drawing.Point(33, 82);
            this.lbl_wpm.Name = "lbl_wpm";
            this.lbl_wpm.Size = new System.Drawing.Size(127, 101);
            this.lbl_wpm.TabIndex = 0;
            this.lbl_wpm.Text = "30";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1292, 111);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FastTyping.Properties.Resources.img_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(80, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 40);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(136, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "FastTyping";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1292, 682);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_WPS;
        private System.Windows.Forms.Label lbl_time_left;
        private System.Windows.Forms.Button btn_Start_Or_Reset;
        private System.Windows.Forms.Timer check_if_first_click;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_wpm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_acc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_raw;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_consistency;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_characters;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private WindowsFormsControlLibrary1.ucTypingBoard typingBoard;
        private ucGraphDrawer.usGraph Graph;
    }
}

