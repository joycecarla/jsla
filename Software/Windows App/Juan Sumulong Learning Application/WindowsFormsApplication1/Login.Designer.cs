namespace juan_sumulong_learning_app
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.btnCancel = new System.Windows.Forms.Button();
            this.tblLayout_login = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayout_loginContent = new System.Windows.Forms.TableLayoutPanel();
            this.txtBox_userID = new System.Windows.Forms.TextBox();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.btn_logIn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picBox_schoolLogo = new System.Windows.Forms.PictureBox();
            this.tblLayout_exit = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayout_login.SuspendLayout();
            this.tblLayout_loginContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_schoolLogo)).BeginInit();
            this.tblLayout_exit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCancel.Location = new System.Drawing.Point(576, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(29, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tblLayout_login
            // 
            this.tblLayout_login.ColumnCount = 1;
            this.tblLayout_login.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout_login.Controls.Add(this.tblLayout_loginContent, 0, 2);
            this.tblLayout_login.Controls.Add(this.picBox_schoolLogo, 0, 1);
            this.tblLayout_login.Controls.Add(this.tblLayout_exit, 0, 0);
            this.tblLayout_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_login.Location = new System.Drawing.Point(0, 0);
            this.tblLayout_login.Name = "tblLayout_login";
            this.tblLayout_login.RowCount = 3;
            this.tblLayout_login.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.240535F));
            this.tblLayout_login.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.30289F));
            this.tblLayout_login.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.45657F));
            this.tblLayout_login.Size = new System.Drawing.Size(389, 449);
            this.tblLayout_login.TabIndex = 6;
            // 
            // tblLayout_loginContent
            // 
            this.tblLayout_loginContent.ColumnCount = 3;
            this.tblLayout_loginContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout_loginContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tblLayout_loginContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tblLayout_loginContent.Controls.Add(this.txtBox_userID, 1, 1);
            this.tblLayout_loginContent.Controls.Add(this.txtBox_password, 1, 2);
            this.tblLayout_loginContent.Controls.Add(this.btn_logIn, 1, 3);
            this.tblLayout_loginContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_loginContent.Location = new System.Drawing.Point(3, 202);
            this.tblLayout_loginContent.Name = "tblLayout_loginContent";
            this.tblLayout_loginContent.RowCount = 4;
            this.tblLayout_loginContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.41177F));
            this.tblLayout_loginContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.58823F));
            this.tblLayout_loginContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tblLayout_loginContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tblLayout_loginContent.Size = new System.Drawing.Size(383, 244);
            this.tblLayout_loginContent.TabIndex = 0;
            // 
            // txtBox_userID
            // 
            this.txtBox_userID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBox_userID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_userID.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.txtBox_userID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtBox_userID.Location = new System.Drawing.Point(70, 45);
            this.txtBox_userID.Name = "txtBox_userID";
            this.txtBox_userID.Size = new System.Drawing.Size(251, 29);
            this.txtBox_userID.TabIndex = 6;
            this.txtBox_userID.Text = "User ID";
            this.txtBox_userID.Enter += new System.EventHandler(this.txtBox_userID_Enter);
            this.txtBox_userID.Leave += new System.EventHandler(this.txtBox_userID_Leave);
            // 
            // txtBox_password
            // 
            this.txtBox_password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_password.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.txtBox_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtBox_password.Location = new System.Drawing.Point(70, 88);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(251, 29);
            this.txtBox_password.TabIndex = 7;
            this.txtBox_password.Text = "Password";
            this.txtBox_password.Enter += new System.EventHandler(this.txtBox_password_Enter);
            this.txtBox_password.Leave += new System.EventHandler(this.txtBox_password_Leave);
            // 
            // btn_logIn
            // 
            this.btn_logIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logIn.Location = new System.Drawing.Point(70, 167);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(251, 39);
            this.btn_logIn.TabIndex = 8;
            this.btn_logIn.Text = "Log In";
            this.btn_logIn.UseVisualStyleBackColor = true;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(357, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBox_schoolLogo
            // 
            this.picBox_schoolLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_schoolLogo.Image")));
            this.picBox_schoolLogo.Location = new System.Drawing.Point(3, 40);
            this.picBox_schoolLogo.Name = "picBox_schoolLogo";
            this.picBox_schoolLogo.Size = new System.Drawing.Size(383, 156);
            this.picBox_schoolLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_schoolLogo.TabIndex = 9;
            this.picBox_schoolLogo.TabStop = false;
            // 
            // tblLayout_exit
            // 
            this.tblLayout_exit.ColumnCount = 2;
            this.tblLayout_exit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.4282F));
            this.tblLayout_exit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.571802F));
            this.tblLayout_exit.Controls.Add(this.button1, 1, 0);
            this.tblLayout_exit.Location = new System.Drawing.Point(3, 3);
            this.tblLayout_exit.Name = "tblLayout_exit";
            this.tblLayout_exit.RowCount = 1;
            this.tblLayout_exit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout_exit.Size = new System.Drawing.Size(383, 31);
            this.tblLayout_exit.TabIndex = 10;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(389, 449);
            this.Controls.Add(this.tblLayout_login);
            this.Controls.Add(this.btnCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tblLayout_login.ResumeLayout(false);
            this.tblLayout_loginContent.ResumeLayout(false);
            this.tblLayout_loginContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_schoolLogo)).EndInit();
            this.tblLayout_exit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tblLayout_login;
        private System.Windows.Forms.TableLayoutPanel tblLayout_loginContent;
        private System.Windows.Forms.TextBox txtBox_userID;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.Button btn_logIn;
        private System.Windows.Forms.PictureBox picBox_schoolLogo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tblLayout_exit;
    }
}