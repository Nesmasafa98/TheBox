namespace The_Box_v0._1.Forms
{
    partial class PlayForm
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
            this.Online_Players_Panel = new System.Windows.Forms.GroupBox();
            this.Online_Players_listBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.New_Room_Button = new System.Windows.Forms.Button();
            this.Available_Rooms_Panel = new System.Windows.Forms.GroupBox();
            this.Available_Rooms_listBox = new System.Windows.Forms.ListBox();
            this.Watch_Button = new System.Windows.Forms.Button();
            this.Available_Rooms = new System.Windows.Forms.Label();
            this.Full_Rooms_Panel = new System.Windows.Forms.GroupBox();
            this.Full_Rooms_listBox = new System.Windows.Forms.ListBox();
            this.Join_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Online_Players_Panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Available_Rooms_Panel.SuspendLayout();
            this.Full_Rooms_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.Online_Players_Panel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 489);
            this.panel1.TabIndex = 0;
            // 
            // Online_Players_Panel
            // 
            this.Online_Players_Panel.Controls.Add(this.Online_Players_listBox);
            this.Online_Players_Panel.Controls.Add(this.label8);
            this.Online_Players_Panel.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.Online_Players_Panel.Location = new System.Drawing.Point(3, 55);
            this.Online_Players_Panel.Name = "Online_Players_Panel";
            this.Online_Players_Panel.Size = new System.Drawing.Size(226, 378);
            this.Online_Players_Panel.TabIndex = 4;
            this.Online_Players_Panel.TabStop = false;
            // 
            // Online_Players_listBox
            // 
            this.Online_Players_listBox.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.Online_Players_listBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Online_Players_listBox.FormattingEnabled = true;
            this.Online_Players_listBox.ItemHeight = 22;
            this.Online_Players_listBox.Location = new System.Drawing.Point(14, 35);
            this.Online_Players_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.Online_Players_listBox.Name = "Online_Players_listBox";
            this.Online_Players_listBox.Size = new System.Drawing.Size(196, 268);
            this.Online_Players_listBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(71, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 18);
            this.label8.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 75);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::The_Box_v0._1.Properties.Resources.rec;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(45, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Online Players";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.New_Room_Button);
            this.panel2.Controls.Add(this.Available_Rooms_Panel);
            this.panel2.Controls.Add(this.Full_Rooms_Panel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(235, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 489);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // New_Room_Button
            // 
            this.New_Room_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.New_Room_Button.FlatAppearance.BorderSize = 0;
            this.New_Room_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_Room_Button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Room_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.New_Room_Button.Location = new System.Drawing.Point(250, 440);
            this.New_Room_Button.Name = "New_Room_Button";
            this.New_Room_Button.Size = new System.Drawing.Size(109, 37);
            this.New_Room_Button.TabIndex = 4;
            this.New_Room_Button.Text = "New Room";
            this.New_Room_Button.UseVisualStyleBackColor = true;
            this.New_Room_Button.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Available_Rooms_Panel
            // 
            this.Available_Rooms_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Available_Rooms_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Available_Rooms_Panel.Controls.Add(this.Available_Rooms_listBox);
            this.Available_Rooms_Panel.Controls.Add(this.Watch_Button);
            this.Available_Rooms_Panel.Controls.Add(this.Available_Rooms);
            this.Available_Rooms_Panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Available_Rooms_Panel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Available_Rooms_Panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Available_Rooms_Panel.Location = new System.Drawing.Point(33, 54);
            this.Available_Rooms_Panel.Margin = new System.Windows.Forms.Padding(3, 303, 3, 3);
            this.Available_Rooms_Panel.Name = "Available_Rooms_Panel";
            this.Available_Rooms_Panel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Available_Rooms_Panel.Size = new System.Drawing.Size(259, 378);
            this.Available_Rooms_Panel.TabIndex = 3;
            this.Available_Rooms_Panel.TabStop = false;
            // 
            // Available_Rooms_listBox
            // 
            this.Available_Rooms_listBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Available_Rooms_listBox.FormattingEnabled = true;
            this.Available_Rooms_listBox.ItemHeight = 22;
            this.Available_Rooms_listBox.Location = new System.Drawing.Point(31, 36);
            this.Available_Rooms_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.Available_Rooms_listBox.Name = "Available_Rooms_listBox";
            this.Available_Rooms_listBox.Size = new System.Drawing.Size(196, 268);
            this.Available_Rooms_listBox.TabIndex = 5;
            this.Available_Rooms_listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.Available_Rooms_listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseDoubleClick);
            // 
            // Watch_Button
            // 
            this.Watch_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Watch_Button.FlatAppearance.BorderSize = 0;
            this.Watch_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Watch_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.Watch_Button.Location = new System.Drawing.Point(96, 328);
            this.Watch_Button.Name = "Watch_Button";
            this.Watch_Button.Size = new System.Drawing.Size(85, 33);
            this.Watch_Button.TabIndex = 2;
            this.Watch_Button.Text = "Watch";
            this.Watch_Button.UseVisualStyleBackColor = false;
            this.Watch_Button.Click += new System.EventHandler(this.button9_Click);
            // 
            // Available_Rooms
            // 
            this.Available_Rooms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Available_Rooms.AutoSize = true;
            this.Available_Rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Available_Rooms.ForeColor = System.Drawing.Color.White;
            this.Available_Rooms.Location = new System.Drawing.Point(71, 0);
            this.Available_Rooms.Name = "Available_Rooms";
            this.Available_Rooms.Size = new System.Drawing.Size(124, 22);
            this.Available_Rooms.TabIndex = 0;
            this.Available_Rooms.Text = "Avialable Rooms";
            this.Available_Rooms.Click += new System.EventHandler(this.label2_Click);
            // 
            // Full_Rooms_Panel
            // 
            this.Full_Rooms_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Full_Rooms_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Full_Rooms_Panel.Controls.Add(this.Full_Rooms_listBox);
            this.Full_Rooms_Panel.Controls.Add(this.Join_Button);
            this.Full_Rooms_Panel.Controls.Add(this.label3);
            this.Full_Rooms_Panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Full_Rooms_Panel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Full_Rooms_Panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Full_Rooms_Panel.Location = new System.Drawing.Point(312, 54);
            this.Full_Rooms_Panel.Margin = new System.Windows.Forms.Padding(3, 303, 3, 3);
            this.Full_Rooms_Panel.Name = "Full_Rooms_Panel";
            this.Full_Rooms_Panel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Full_Rooms_Panel.Size = new System.Drawing.Size(259, 378);
            this.Full_Rooms_Panel.TabIndex = 3;
            this.Full_Rooms_Panel.TabStop = false;
            // 
            // Full_Rooms_listBox
            // 
            this.Full_Rooms_listBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Full_Rooms_listBox.FormattingEnabled = true;
            this.Full_Rooms_listBox.ItemHeight = 22;
            this.Full_Rooms_listBox.Location = new System.Drawing.Point(34, 36);
            this.Full_Rooms_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.Full_Rooms_listBox.Name = "Full_Rooms_listBox";
            this.Full_Rooms_listBox.Size = new System.Drawing.Size(196, 268);
            this.Full_Rooms_listBox.TabIndex = 2;
            // 
            // Join_Button
            // 
            this.Join_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Join_Button.FlatAppearance.BorderSize = 0;
            this.Join_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Join_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.Join_Button.Location = new System.Drawing.Point(88, 328);
            this.Join_Button.Name = "Join_Button";
            this.Join_Button.Size = new System.Drawing.Size(85, 33);
            this.Join_Button.TabIndex = 2;
            this.Join_Button.Text = "Join";
            this.Join_Button.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Full Rooms";
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PlayForm";
            this.Text = "Play";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.panel1.ResumeLayout(false);
            this.Online_Players_Panel.ResumeLayout(false);
            this.Online_Players_Panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.Available_Rooms_Panel.ResumeLayout(false);
            this.Available_Rooms_Panel.PerformLayout();
            this.Full_Rooms_Panel.ResumeLayout(false);
            this.Full_Rooms_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox Available_Rooms_Panel;
        private System.Windows.Forms.Label Available_Rooms;
        private System.Windows.Forms.GroupBox Full_Rooms_Panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button New_Room_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Online_Players_Panel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Watch_Button;
        private System.Windows.Forms.Button Join_Button;
        private System.Windows.Forms.ListBox Online_Players_listBox;
        private System.Windows.Forms.ListBox Available_Rooms_listBox;
        private System.Windows.Forms.ListBox Full_Rooms_listBox;
    }
}