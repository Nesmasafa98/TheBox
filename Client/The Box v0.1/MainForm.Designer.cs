namespace The_Box_v0._1
{
    partial class MainForm
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
            this.HdrPanel = new System.Windows.Forms.Panel();
            this.CloseAppbtn = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.MaximizeAppbtn = new System.Windows.Forms.Button();
            this.CloseFormbtn = new System.Windows.Forms.Button();
            this.boxLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.SignoutBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.WelcPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HdrPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.WelcPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HdrPanel
            // 
            this.HdrPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.HdrPanel.Controls.Add(this.CloseAppbtn);
            this.HdrPanel.Controls.Add(this.Minimize);
            this.HdrPanel.Controls.Add(this.MaximizeAppbtn);
            this.HdrPanel.Controls.Add(this.CloseFormbtn);
            this.HdrPanel.Controls.Add(this.boxLabel);
            this.HdrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HdrPanel.Location = new System.Drawing.Point(253, 0);
            this.HdrPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HdrPanel.Name = "HdrPanel";
            this.HdrPanel.Size = new System.Drawing.Size(1167, 96);
            this.HdrPanel.TabIndex = 1;
            this.HdrPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HdrPanel_MouseDown);
            // 
            // CloseAppbtn
            // 
            this.CloseAppbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseAppbtn.FlatAppearance.BorderSize = 0;
            this.CloseAppbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAppbtn.Image = global::The_Box_v0._1.Properties.Resources.close__2_;
            this.CloseAppbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseAppbtn.Location = new System.Drawing.Point(1123, 4);
            this.CloseAppbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseAppbtn.Name = "CloseAppbtn";
            this.CloseAppbtn.Size = new System.Drawing.Size(37, 28);
            this.CloseAppbtn.TabIndex = 5;
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
            this.Minimize.Location = new System.Drawing.Point(1032, 4);
            this.Minimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(37, 28);
            this.Minimize.TabIndex = 4;
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
            this.MaximizeAppbtn.Location = new System.Drawing.Point(1077, 4);
            this.MaximizeAppbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeAppbtn.Name = "MaximizeAppbtn";
            this.MaximizeAppbtn.Size = new System.Drawing.Size(37, 28);
            this.MaximizeAppbtn.TabIndex = 3;
            this.MaximizeAppbtn.UseVisualStyleBackColor = true;
            this.MaximizeAppbtn.Click += new System.EventHandler(this.MaximizeAppbtn_Click);
            // 
            // CloseFormbtn
            // 
            this.CloseFormbtn.FlatAppearance.BorderSize = 0;
            this.CloseFormbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseFormbtn.Image = global::The_Box_v0._1.Properties.Resources.close__1_;
            this.CloseFormbtn.Location = new System.Drawing.Point(32, 36);
            this.CloseFormbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseFormbtn.Name = "CloseFormbtn";
            this.CloseFormbtn.Size = new System.Drawing.Size(35, 31);
            this.CloseFormbtn.TabIndex = 2;
            this.CloseFormbtn.UseVisualStyleBackColor = true;
            this.CloseFormbtn.Click += new System.EventHandler(this.CloseFormbtn_Click);
            // 
            // boxLabel
            // 
            this.boxLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.boxLabel.AutoSize = true;
            this.boxLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxLabel.Font = new System.Drawing.Font("Trebuchet MS", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.boxLabel.Location = new System.Drawing.Point(477, 11);
            this.boxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.boxLabel.Name = "boxLabel";
            this.boxLabel.Size = new System.Drawing.Size(256, 73);
            this.boxLabel.TabIndex = 1;
            this.boxLabel.Text = "The Box";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.LeftPanel);
            this.panel1.Controls.Add(this.WelcPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 738);
            this.panel1.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.LeftPanel.Controls.Add(this.SignoutBtn);
            this.LeftPanel.Controls.Add(this.AboutBtn);
            this.LeftPanel.Controls.Add(this.SettingBtn);
            this.LeftPanel.Controls.Add(this.PlayBtn);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.LeftPanel.Location = new System.Drawing.Point(0, 96);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(253, 642);
            this.LeftPanel.TabIndex = 1;
            // 
            // SignoutBtn
            // 
            this.SignoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SignoutBtn.FlatAppearance.BorderSize = 0;
            this.SignoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignoutBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignoutBtn.ForeColor = System.Drawing.Color.White;
            this.SignoutBtn.Image = global::The_Box_v0._1.Properties.Resources.logout;
            this.SignoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignoutBtn.Location = new System.Drawing.Point(0, 568);
            this.SignoutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SignoutBtn.Name = "SignoutBtn";
            this.SignoutBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.SignoutBtn.Size = new System.Drawing.Size(253, 74);
            this.SignoutBtn.TabIndex = 3;
            this.SignoutBtn.Text = "  SignOut";
            this.SignoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SignoutBtn.UseVisualStyleBackColor = true;
            this.SignoutBtn.Click += new System.EventHandler(this.SignoutBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutBtn.FlatAppearance.BorderSize = 0;
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutBtn.ForeColor = System.Drawing.Color.White;
            this.AboutBtn.Image = global::The_Box_v0._1.Properties.Resources.man;
            this.AboutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutBtn.Location = new System.Drawing.Point(0, 148);
            this.AboutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.AboutBtn.Size = new System.Drawing.Size(253, 74);
            this.AboutBtn.TabIndex = 2;
            this.AboutBtn.Text = "  AboutUs";
            this.AboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingBtn.FlatAppearance.BorderSize = 0;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingBtn.ForeColor = System.Drawing.Color.White;
            this.SettingBtn.Image = global::The_Box_v0._1.Properties.Resources.settings__2_;
            this.SettingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingBtn.Location = new System.Drawing.Point(0, 74);
            this.SettingBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.SettingBtn.Size = new System.Drawing.Size(253, 74);
            this.SettingBtn.TabIndex = 1;
            this.SettingBtn.Text = "  Account Settings";
            this.SettingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingBtn.UseVisualStyleBackColor = true;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlayBtn.FlatAppearance.BorderSize = 0;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.ForeColor = System.Drawing.Color.White;
            this.PlayBtn.Image = global::The_Box_v0._1.Properties.Resources.video_console;
            this.PlayBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayBtn.Location = new System.Drawing.Point(0, 0);
            this.PlayBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.PlayBtn.Size = new System.Drawing.Size(253, 74);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.Text = "  Play";
            this.PlayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // WelcPanel
            // 
            this.WelcPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.WelcPanel.Controls.Add(this.textBox1);
            this.WelcPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WelcPanel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.WelcPanel.Location = new System.Drawing.Point(0, 0);
            this.WelcPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WelcPanel.Name = "WelcPanel";
            this.WelcPanel.Size = new System.Drawing.Size(253, 96);
            this.WelcPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPanel.BackgroundImage = global::The_Box_v0._1.Properties.Resources.Logo;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainPanel.CausesValidation = false;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(253, 96);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1167, 642);
            this.MainPanel.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 22);
            this.textBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1420, 738);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.HdrPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1200, 738);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.HdrPanel.ResumeLayout(false);
            this.HdrPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.WelcPanel.ResumeLayout(false);
            this.WelcPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HdrPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel WelcPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button SignoutBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Label boxLabel;
        private System.Windows.Forms.Button CloseFormbtn;
        private System.Windows.Forms.Button MaximizeAppbtn;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button CloseAppbtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}