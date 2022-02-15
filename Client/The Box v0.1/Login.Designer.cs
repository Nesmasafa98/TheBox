namespace The_Box_v0._1
{
    partial class Login
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
            this.Log_In_Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.User_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HeadLoginPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HeadLoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_In_Button
            // 
            this.Log_In_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Log_In_Button.FlatAppearance.BorderSize = 0;
            this.Log_In_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log_In_Button.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_In_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.Log_In_Button.Location = new System.Drawing.Point(91, 312);
            this.Log_In_Button.Name = "Log_In_Button";
            this.Log_In_Button.Size = new System.Drawing.Size(133, 57);
            this.Log_In_Button.TabIndex = 1;
            this.Log_In_Button.Text = "Log In";
            this.Log_In_Button.UseVisualStyleBackColor = false;
            this.Log_In_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.button2.Location = new System.Drawing.Point(102, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // User_Name
            // 
            this.User_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.User_Name.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.User_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.User_Name.Location = new System.Drawing.Point(44, 199);
            this.User_Name.Margin = new System.Windows.Forms.Padding(2);
            this.User_Name.Multiline = true;
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(204, 40);
            this.User_Name.TabIndex = 7;
            this.User_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(63, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "This username already exists";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(63, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username is required";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(40, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "User Name :";
            // 
            // HeadLoginPanel
            // 
            this.HeadLoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.HeadLoginPanel.BackgroundImage = global::The_Box_v0._1.Properties.Resources.connect_four;
            this.HeadLoginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HeadLoginPanel.Controls.Add(this.label1);
            this.HeadLoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadLoginPanel.Name = "HeadLoginPanel";
            this.HeadLoginPanel.Size = new System.Drawing.Size(315, 100);
            this.HeadLoginPanel.TabIndex = 0;
            this.HeadLoginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadLoginPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(69, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connect 4";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(315, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.User_Name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Log_In_Button);
            this.Controls.Add(this.HeadLoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.HeadLoginPanel.ResumeLayout(false);
            this.HeadLoginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeadLoginPanel;
        private System.Windows.Forms.Button Log_In_Button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox User_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

