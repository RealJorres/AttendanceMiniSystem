namespace ProgrammingFinalProject
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.chk_showPass = new System.Windows.Forms.CheckBox();
            this.txt_confirmNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_changePassword = new Telerik.WinControls.UI.RadButton();
            this.txt_cPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_home = new ProgrammingFinalProject.CircularButtons();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btn_changePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_showPass
            // 
            this.chk_showPass.AutoSize = true;
            this.chk_showPass.BackColor = System.Drawing.Color.Transparent;
            this.chk_showPass.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_showPass.ForeColor = System.Drawing.Color.Green;
            this.chk_showPass.Location = new System.Drawing.Point(330, 312);
            this.chk_showPass.Name = "chk_showPass";
            this.chk_showPass.Size = new System.Drawing.Size(117, 20);
            this.chk_showPass.TabIndex = 21;
            this.chk_showPass.Text = "Show Password";
            this.toolTip1.SetToolTip(this.chk_showPass, "Show/Hide password");
            this.chk_showPass.UseVisualStyleBackColor = false;
            this.chk_showPass.CheckedChanged += new System.EventHandler(this.chk_showPass_CheckedChanged);
            // 
            // txt_confirmNewPassword
            // 
            this.txt_confirmNewPassword.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmNewPassword.Location = new System.Drawing.Point(330, 276);
            this.txt_confirmNewPassword.Name = "txt_confirmNewPassword";
            this.txt_confirmNewPassword.PasswordChar = '•';
            this.txt_confirmNewPassword.Size = new System.Drawing.Size(202, 30);
            this.txt_confirmNewPassword.TabIndex = 20;
            this.toolTip1.SetToolTip(this.txt_confirmNewPassword, "Input the Admin\'s new password for confirmation");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(96, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Confirm New Password:";
            // 
            // txt_nPassword
            // 
            this.txt_nPassword.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nPassword.Location = new System.Drawing.Point(330, 239);
            this.txt_nPassword.Name = "txt_nPassword";
            this.txt_nPassword.PasswordChar = '•';
            this.txt_nPassword.Size = new System.Drawing.Size(202, 30);
            this.txt_nPassword.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txt_nPassword, "Input Admin\'s new password");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(174, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "New Password:";
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changePassword.ForeColor = System.Drawing.Color.Green;
            this.btn_changePassword.Location = new System.Drawing.Point(330, 343);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(202, 63);
            this.btn_changePassword.TabIndex = 16;
            this.btn_changePassword.Text = "Change Password";
            this.toolTip1.SetToolTip(this.btn_changePassword, "Change Password");
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // txt_cPassword
            // 
            this.txt_cPassword.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cPassword.Location = new System.Drawing.Point(330, 203);
            this.txt_cPassword.Name = "txt_cPassword";
            this.txt_cPassword.PasswordChar = '•';
            this.txt_cPassword.Size = new System.Drawing.Size(202, 30);
            this.txt_cPassword.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txt_cPassword, "Input Admin\'s current password");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(145, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Current Password:";
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_home.BackgroundImage = global::ProgrammingFinalProject.Properties.Resources.New2;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.Location = new System.Drawing.Point(25, 7);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(125, 108);
            this.btn_home.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_home, "To Administrator\'s Privileges");
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 500);
            this.Controls.Add(this.chk_showPass);
            this.Controls.Add(this.txt_confirmNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_changePassword);
            this.Controls.Add(this.txt_cPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_home);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangePassword";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ThemeName = "Windows8";
            ((System.ComponentModel.ISupportInitialize)(this.btn_changePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularButtons btn_home;
        private System.Windows.Forms.CheckBox chk_showPass;
        private System.Windows.Forms.TextBox txt_confirmNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nPassword;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton btn_changePassword;
        private System.Windows.Forms.TextBox txt_cPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
