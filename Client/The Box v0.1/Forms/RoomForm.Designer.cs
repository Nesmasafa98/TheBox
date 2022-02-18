namespace The_Box_v0._1.Forms
{
    partial class RoomForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Player1_Color = new System.Windows.Forms.Label();
            this.Player2_Color = new System.Windows.Forms.Label();
            this.Player2_Name = new System.Windows.Forms.Label();
            this.Player1_Name = new System.Windows.Forms.Label();
            this.Player2_Color_label = new System.Windows.Forms.Label();
            this.Player1_Color_label = new System.Windows.Forms.Label();
            this.Player2_Name_label = new System.Windows.Forms.Label();
            this.Player1_Name_label = new System.Windows.Forms.Label();
            this.LabelRoomName = new System.Windows.Forms.Label();
            this.CloseAppbtn = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.MaximizeAppbtn = new System.Windows.Forms.Button();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.BoardPanel = new System.Windows.Forms.Panel();
            this.Reset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Player1_Color);
            this.panel1.Controls.Add(this.Player2_Color);
            this.panel1.Controls.Add(this.Player2_Name);
            this.panel1.Controls.Add(this.Player1_Name);
            this.panel1.Controls.Add(this.Player2_Color_label);
            this.panel1.Controls.Add(this.Player1_Color_label);
            this.panel1.Controls.Add(this.Player2_Name_label);
            this.panel1.Controls.Add(this.Player1_Name_label);
            this.panel1.Controls.Add(this.LabelRoomName);
            this.panel1.Controls.Add(this.CloseAppbtn);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.MaximizeAppbtn);
            this.panel1.Controls.Add(this.Player2);
            this.panel1.Controls.Add(this.Player1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Player1_Color
            // 
            this.Player1_Color.AutoSize = true;
            this.Player1_Color.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.Player1_Color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Player1_Color.Location = new System.Drawing.Point(187, 59);
            this.Player1_Color.Name = "Player1_Color";
            this.Player1_Color.Size = new System.Drawing.Size(89, 18);
            this.Player1_Color.TabIndex = 19;
            this.Player1_Color.Text = "Player1 Color";
            // 
            // Player2_Color
            // 
            this.Player2_Color.AutoSize = true;
            this.Player2_Color.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.Player2_Color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Player2_Color.Location = new System.Drawing.Point(858, 59);
            this.Player2_Color.Name = "Player2_Color";
            this.Player2_Color.Size = new System.Drawing.Size(89, 18);
            this.Player2_Color.TabIndex = 18;
            this.Player2_Color.Text = "Player2 Color";
            // 
            // Player2_Name
            // 
            this.Player2_Name.AutoSize = true;
            this.Player2_Name.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.Player2_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Player2_Name.Location = new System.Drawing.Point(858, 32);
            this.Player2_Name.Name = "Player2_Name";
            this.Player2_Name.Size = new System.Drawing.Size(92, 18);
            this.Player2_Name.TabIndex = 17;
            this.Player2_Name.Text = "Player2 Name";
            // 
            // Player1_Name
            // 
            this.Player1_Name.AutoSize = true;
            this.Player1_Name.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.Player1_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Player1_Name.Location = new System.Drawing.Point(187, 32);
            this.Player1_Name.Name = "Player1_Name";
            this.Player1_Name.Size = new System.Drawing.Size(92, 18);
            this.Player1_Name.TabIndex = 16;
            this.Player1_Name.Text = "Player1 Name";
            // 
            // Player2_Color_label
            // 
            this.Player2_Color_label.AutoSize = true;
            this.Player2_Color_label.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.Player2_Color_label.ForeColor = System.Drawing.Color.White;
            this.Player2_Color_label.Location = new System.Drawing.Point(779, 55);
            this.Player2_Color_label.Name = "Player2_Color_label";
            this.Player2_Color_label.Size = new System.Drawing.Size(59, 22);
            this.Player2_Color_label.TabIndex = 15;
            this.Player2_Color_label.Text = "Color :";
            // 
            // Player1_Color_label
            // 
            this.Player1_Color_label.AutoSize = true;
            this.Player1_Color_label.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.Player1_Color_label.ForeColor = System.Drawing.Color.White;
            this.Player1_Color_label.Location = new System.Drawing.Point(108, 55);
            this.Player1_Color_label.Name = "Player1_Color_label";
            this.Player1_Color_label.Size = new System.Drawing.Size(59, 22);
            this.Player1_Color_label.TabIndex = 14;
            this.Player1_Color_label.Text = "Color :";
            // 
            // Player2_Name_label
            // 
            this.Player2_Name_label.AutoSize = true;
            this.Player2_Name_label.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.Player2_Name_label.ForeColor = System.Drawing.Color.White;
            this.Player2_Name_label.Location = new System.Drawing.Point(779, 26);
            this.Player2_Name_label.Name = "Player2_Name_label";
            this.Player2_Name_label.Size = new System.Drawing.Size(78, 22);
            this.Player2_Name_label.TabIndex = 13;
            this.Player2_Name_label.Text = "Player 2 :";
            // 
            // Player1_Name_label
            // 
            this.Player1_Name_label.AutoSize = true;
            this.Player1_Name_label.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.Player1_Name_label.ForeColor = System.Drawing.Color.White;
            this.Player1_Name_label.Location = new System.Drawing.Point(108, 26);
            this.Player1_Name_label.Name = "Player1_Name_label";
            this.Player1_Name_label.Size = new System.Drawing.Size(73, 22);
            this.Player1_Name_label.TabIndex = 12;
            this.Player1_Name_label.Text = "Player1 :";
            // 
            // LabelRoomName
            // 
            this.LabelRoomName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelRoomName.Location = new System.Drawing.Point(505, 72);
            this.LabelRoomName.Name = "LabelRoomName";
            this.LabelRoomName.Size = new System.Drawing.Size(81, 25);
            this.LabelRoomName.TabIndex = 10;
            this.LabelRoomName.Text = "label";
            // 
            // CloseAppbtn
            // 
            this.CloseAppbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseAppbtn.FlatAppearance.BorderSize = 0;
            this.CloseAppbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAppbtn.Image = global::The_Box_v0._1.Properties.Resources.close__2_;
            this.CloseAppbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseAppbtn.Location = new System.Drawing.Point(1085, 3);
            this.CloseAppbtn.Name = "CloseAppbtn";
            this.CloseAppbtn.Size = new System.Drawing.Size(28, 23);
            this.CloseAppbtn.TabIndex = 8;
            this.CloseAppbtn.UseVisualStyleBackColor = true;
            this.CloseAppbtn.Click += new System.EventHandler(this.CloseAppbtn_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Image = global::The_Box_v0._1.Properties.Resources.minus;
            this.Minimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimize.Location = new System.Drawing.Point(1017, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(28, 23);
            this.Minimize.TabIndex = 7;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // MaximizeAppbtn
            // 
            this.MaximizeAppbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeAppbtn.FlatAppearance.BorderSize = 0;
            this.MaximizeAppbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeAppbtn.Image = global::The_Box_v0._1.Properties.Resources.fullscreen;
            this.MaximizeAppbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MaximizeAppbtn.Location = new System.Drawing.Point(1051, 3);
            this.MaximizeAppbtn.Name = "MaximizeAppbtn";
            this.MaximizeAppbtn.Size = new System.Drawing.Size(28, 23);
            this.MaximizeAppbtn.TabIndex = 6;
            this.MaximizeAppbtn.UseVisualStyleBackColor = true;
            this.MaximizeAppbtn.Click += new System.EventHandler(this.MaximizeAppbtn_Click);
            // 
            // Player2
            // 
            this.Player2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player2.Image = global::The_Box_v0._1.Properties.Resources.american_football_player__1_;
            this.Player2.Location = new System.Drawing.Point(684, 13);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(64, 64);
            this.Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player2.TabIndex = 3;
            this.Player2.TabStop = false;
            // 
            // Player1
            // 
            this.Player1.Image = global::The_Box_v0._1.Properties.Resources.american_football_player__1_;
            this.Player1.Location = new System.Drawing.Point(30, 13);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(64, 64);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.PlayBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.PlayBtn.Location = new System.Drawing.Point(30, 176);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(119, 37);
            this.PlayBtn.TabIndex = 9;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Reset);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.QuitBtn);
            this.panel2.Controls.Add(this.PlayBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 562);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.button1.Location = new System.Drawing.Point(30, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QuitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.QuitBtn.FlatAppearance.BorderSize = 0;
            this.QuitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.QuitBtn.Location = new System.Drawing.Point(30, 243);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(119, 33);
            this.QuitBtn.TabIndex = 3;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = false;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // BoardPanel
            // 
            this.BoardPanel.Location = new System.Drawing.Point(197, 100);
            this.BoardPanel.Name = "BoardPanel";
            this.BoardPanel.Size = new System.Drawing.Size(917, 562);
            this.BoardPanel.TabIndex = 2;
            this.BoardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BoardPanel_Paint);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.Reset.Location = new System.Drawing.Point(30, 121);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(119, 37);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1114, 662);
            this.Controls.Add(this.BoardPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoardForm";
            this.Resize += new System.EventHandler(this.BoardForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.Button CloseAppbtn;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button MaximizeAppbtn;
        private System.Windows.Forms.Panel BoardPanel;
        public System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Label LabelRoomName;
        private System.Windows.Forms.Label Player2_Color_label;
        private System.Windows.Forms.Label Player1_Color_label;
        private System.Windows.Forms.Label Player2_Name_label;
        private System.Windows.Forms.Label Player1_Name_label;
        public System.Windows.Forms.Label Player1_Name;
        public System.Windows.Forms.Label Player1_Color;
        public System.Windows.Forms.Label Player2_Color;
        public System.Windows.Forms.Label Player2_Name;
        public System.Windows.Forms.Button Reset;
    }
}