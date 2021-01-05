namespace test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_stop = new System.Windows.Forms.Button();
            this.lbl2_previous = new System.Windows.Forms.Button();
            this.lbl1_next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_Pause = new System.Windows.Forms.Button();
            this.lbl_play = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(0, 24);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(1255, 474);
            this.axWindowsMediaPlayer2.TabIndex = 0;
            this.axWindowsMediaPlayer2.Enter += new System.EventHandler(this.axWindowsMediaPlayer2_Enter);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar1.Location = new System.Drawing.Point(682, 524);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(130, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar2.ForeColor = System.Drawing.Color.Green;
            this.progressBar2.Location = new System.Drawing.Point(81, 501);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(731, 17);
            this.progressBar2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(45, 25);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Menu";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(45, 1);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(39, 25);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "View";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(84, 1);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(48, 25);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.Text = "About";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.textBox1.Location = new System.Drawing.Point(1031, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Shrouk Media Player";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_stop
            // 
            this.lbl_stop.Image = ((System.Drawing.Image)(resources.GetObject("lbl_stop.Image")));
            this.lbl_stop.Location = new System.Drawing.Point(184, 521);
            this.lbl_stop.Name = "lbl_stop";
            this.lbl_stop.Size = new System.Drawing.Size(40, 40);
            this.lbl_stop.TabIndex = 8;
            this.lbl_stop.UseVisualStyleBackColor = true;
            // 
            // lbl2_previous
            // 
            this.lbl2_previous.Image = ((System.Drawing.Image)(resources.GetObject("lbl2_previous.Image")));
            this.lbl2_previous.Location = new System.Drawing.Point(46, 521);
            this.lbl2_previous.Name = "lbl2_previous";
            this.lbl2_previous.Size = new System.Drawing.Size(40, 40);
            this.lbl2_previous.TabIndex = 9;
            this.lbl2_previous.UseVisualStyleBackColor = true;
            this.lbl2_previous.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl1_next
            // 
            this.lbl1_next.Image = ((System.Drawing.Image)(resources.GetObject("lbl1_next.Image")));
            this.lbl1_next.Location = new System.Drawing.Point(138, 521);
            this.lbl1_next.Name = "lbl1_next";
            this.lbl1_next.Size = new System.Drawing.Size(40, 40);
            this.lbl1_next.TabIndex = 10;
            this.lbl1_next.UseVisualStyleBackColor = true;
            this.lbl1_next.Click += new System.EventHandler(this.lbl1_next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(818, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(11, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(734, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "0%";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(888, 504);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(367, 84);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbl_Pause
            // 
            this.lbl_Pause.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Pause.Image")));
            this.lbl_Pause.Location = new System.Drawing.Point(92, 521);
            this.lbl_Pause.Name = "lbl_Pause";
            this.lbl_Pause.Size = new System.Drawing.Size(40, 40);
            this.lbl_Pause.TabIndex = 11;
            this.lbl_Pause.UseVisualStyleBackColor = true;
            this.lbl_Pause.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbl_play
            // 
            this.lbl_play.Image = ((System.Drawing.Image)(resources.GetObject("lbl_play.Image")));
            this.lbl_play.Location = new System.Drawing.Point(0, 521);
            this.lbl_play.Name = "lbl_play";
            this.lbl_play.Size = new System.Drawing.Size(40, 40);
            this.lbl_play.TabIndex = 7;
            this.lbl_play.UseVisualStyleBackColor = true;
            this.lbl_play.Click += new System.EventHandler(this.lbl_play_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(376, 530);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 16;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1261, 589);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Pause);
            this.Controls.Add(this.lbl1_next);
            this.Controls.Add(this.lbl2_previous);
            this.Controls.Add(this.lbl_stop);
            this.Controls.Add(this.lbl_play);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button lbl_play;
        private System.Windows.Forms.Button lbl_stop;
        private System.Windows.Forms.Button lbl2_previous;
        private System.Windows.Forms.Button lbl1_next;
        private System.Windows.Forms.Button lbl_Pause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Open;
    }
}

