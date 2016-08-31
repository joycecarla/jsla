namespace juan_sumulong_learning_app
{
    partial class Announcements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Announcements));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1920x1080-Wallpaper-Image-H5S.jpg");
            this.imageList1.Images.SetKeyName(1, "boat.jpg");
            this.imageList1.Images.SetKeyName(2, "caty.jpg");
            this.imageList1.Images.SetKeyName(3, "butterfly.jpg");
            this.imageList1.Images.SetKeyName(4, "city.jpg");
            this.imageList1.Images.SetKeyName(5, "desert.jpg");
            this.imageList1.Images.SetKeyName(6, "download.jpg");
            this.imageList1.Images.SetKeyName(7, "flower.jpg");
            this.imageList1.Images.SetKeyName(8, "flowers.jpg");
            this.imageList1.Images.SetKeyName(9, "galaxy.jpg");
            this.imageList1.Images.SetKeyName(10, "images (3).jpg");
            this.imageList1.Images.SetKeyName(11, "images.jpg");
            this.imageList1.Images.SetKeyName(12, "night.jpg");
            this.imageList1.Images.SetKeyName(13, "sunset.jpg");
            this.imageList1.Images.SetKeyName(14, "surf.jpg");
            this.imageList1.Images.SetKeyName(15, "tiger.jpg");
            this.imageList1.Images.SetKeyName(16, "water.jpg");
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Announcements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 217);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Announcements";
            this.Text = "Announcements";
            this.Load += new System.EventHandler(this.Announcements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
    }
}