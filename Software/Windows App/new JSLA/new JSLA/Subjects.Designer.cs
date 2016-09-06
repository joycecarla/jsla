namespace new_JSLA
{
    partial class Subjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            this.picturebutton1 = new new_JSLA.picturebutton();
            this.SuspendLayout();
            // 
            // picturebutton1
            // 
            this.picturebutton1.Descripiton = "label2";
            this.picturebutton1.Image = ((System.Drawing.Image)(resources.GetObject("picturebutton1.Image")));
            this.picturebutton1.Location = new System.Drawing.Point(12, 12);
            this.picturebutton1.Name = "picturebutton1";
            this.picturebutton1.Size = new System.Drawing.Size(151, 186);
            this.picturebutton1.TabIndex = 0;
            this.picturebutton1.Title = "label1";
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1113, 542);
            this.Controls.Add(this.picturebutton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.ResumeLayout(false);

        }

        #endregion

        private picturebutton picturebutton1;


    }
}