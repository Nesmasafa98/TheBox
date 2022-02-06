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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            this.HeadLoginPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HeadLoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.button1.Location = new System.Drawing.Point(91, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // materialTextBox22
            // 
            this.materialTextBox22.AnimateReadOnly = false;
            this.materialTextBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox22.Depth = 0;
            this.materialTextBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox22.HideSelection = true;
            this.materialTextBox22.LeadingIcon = null;
            this.materialTextBox22.Location = new System.Drawing.Point(40, 191);
            this.materialTextBox22.MaxLength = 32767;
            this.materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox22.Name = "materialTextBox22";
            this.materialTextBox22.PasswordChar = '\0';
            this.materialTextBox22.PrefixSuffixText = null;
            this.materialTextBox22.ReadOnly = false;
            this.materialTextBox22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox22.SelectedText = "";
            this.materialTextBox22.SelectionLength = 0;
            this.materialTextBox22.SelectionStart = 0;
            this.materialTextBox22.ShortcutsEnabled = true;
            this.materialTextBox22.Size = new System.Drawing.Size(250, 48);
            this.materialTextBox22.TabIndex = 3;
            this.materialTextBox22.TabStop = false;
            this.materialTextBox22.Text = "User Name";
            this.materialTextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox22.TrailingIcon = global::The_Box_v0._1.Properties.Resources.identification;
            this.materialTextBox22.UseSystemPasswordChar = false;
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
            this.label1.Location = new System.Drawing.Point(83, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Box";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(315, 438);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.materialTextBox22);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HeadLoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.HeadLoginPanel.ResumeLayout(false);
            this.HeadLoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeadLoginPanel;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

