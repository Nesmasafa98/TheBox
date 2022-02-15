namespace The_Box_v0._1.Forms
{
    partial class ImageForm
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
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.MainImage = new System.Windows.Forms.PictureBox();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePanel
            // 
            this.ImagePanel.Controls.Add(this.MainImage);
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImagePanel.Location = new System.Drawing.Point(0, 0);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(800, 344);
            this.ImagePanel.TabIndex = 0;
            // 
            // MainImage
            // 
            this.MainImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainImage.Location = new System.Drawing.Point(0, 0);
            this.MainImage.Name = "MainImage";
            this.MainImage.Size = new System.Drawing.Size(800, 344);
            this.MainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainImage.TabIndex = 0;
            this.MainImage.TabStop = false;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImagePanel);
            this.Name = "ImageForm";
            this.Text = "ImageForm";
            this.ImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.PictureBox MainImage;
    }
}