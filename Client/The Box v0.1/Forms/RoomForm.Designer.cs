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
            this.LabelRoomName = new System.Windows.Forms.Label();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.CloseAppbtn = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.MaximizeAppbtn = new System.Windows.Forms.Button();
            this.Player2Color = new System.Windows.Forms.Label();
            this.Player2Username = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Player1Color = new System.Windows.Forms.Label();
            this.Player1Username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.BoardPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelRoomName);
            this.panel1.Controls.Add(this.PlayBtn);
            this.panel1.Controls.Add(this.CloseAppbtn);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.MaximizeAppbtn);
            this.panel1.Controls.Add(this.Player2Color);
            this.panel1.Controls.Add(this.Player2Username);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Player1Color);
            this.panel1.Controls.Add(this.Player1Username);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 100);
            this.panel1.TabIndex = 0;
           
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            // PlayBtn
            // 
            this.PlayBtn.Location = new System.Drawing.Point(508, 36);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(75, 23);
            this.PlayBtn.TabIndex = 9;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
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
            // Player2Color
            // 
            this.Player2Color.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player2Color.AutoSize = true;
            this.Player2Color.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Color.ForeColor = System.Drawing.Color.White;
            this.Player2Color.Location = new System.Drawing.Point(881, 36);
            this.Player2Color.Name = "Player2Color";
            this.Player2Color.Size = new System.Drawing.Size(54, 24);
            this.Player2Color.TabIndex = 5;
            this.Player2Color.Text = "Color";
            // 
            // Player2Username
            // 
            this.Player2Username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player2Username.AutoSize = true;
            this.Player2Username.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Username.ForeColor = System.Drawing.Color.White;
            this.Player2Username.Location = new System.Drawing.Point(881, 12);
            this.Player2Username.Name = "Player2Username";
            this.Player2Username.Size = new System.Drawing.Size(73, 24);
            this.Player2Username.TabIndex = 4;
            this.Player2Username.Text = "Player2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::The_Box_v0._1.Properties.Resources.american_football_player__1_;
            this.pictureBox2.Location = new System.Drawing.Point(811, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Player1Color
            // 
            this.Player1Color.AutoSize = true;
            this.Player1Color.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Color.ForeColor = System.Drawing.Color.White;
            this.Player1Color.Location = new System.Drawing.Point(221, 36);
            this.Player1Color.Name = "Player1Color";
            this.Player1Color.Size = new System.Drawing.Size(54, 24);
            this.Player1Color.TabIndex = 2;
            this.Player1Color.Text = "Color";
            // 
            // Player1Username
            // 
            this.Player1Username.AutoSize = true;
            this.Player1Username.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Username.ForeColor = System.Drawing.Color.White;
            this.Player1Username.Location = new System.Drawing.Point(221, 12);
            this.Player1Username.Name = "Player1Username";
            this.Player1Username.Size = new System.Drawing.Size(73, 24);
            this.Player1Username.TabIndex = 1;
            this.Player1Username.Text = "Player1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::The_Box_v0._1.Properties.Resources.american_football_player__1_;
            this.pictureBox1.Location = new System.Drawing.Point(151, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.QuitBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 562);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(50, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Watchers";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.listBox1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(18, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 224);
            this.listBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.button1.Location = new System.Drawing.Point(12, 508);
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
            this.QuitBtn.Location = new System.Drawing.Point(12, 469);
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
            this.BoardPanel.Size = new System.Drawing.Size(917, 559);
            this.BoardPanel.TabIndex = 2;
            this.BoardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BoardPanel_Paint);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Player1Username;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Label Player2Color;
        private System.Windows.Forms.Label Player2Username;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Player1Color;
        private System.Windows.Forms.Button CloseAppbtn;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button MaximizeAppbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel BoardPanel;
        public System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Label LabelRoomName;
    }
}