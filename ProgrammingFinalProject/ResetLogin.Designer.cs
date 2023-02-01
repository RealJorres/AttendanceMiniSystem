namespace ProgrammingFinalProject
{
    partial class ResetLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetLogin));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txt_cUsername = new Telerik.WinControls.UI.RadTextBox();
            this.txt_cPassword = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btn_resetLogin = new Telerik.WinControls.UI.RadButton();
            this.btn_home = new ProgrammingFinalProject.CircularButtons();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_resetLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.Green;
            this.radLabel1.Location = new System.Drawing.Point(164, 192);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(181, 27);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Current Username:";
            // 
            // txt_cUsername
            // 
            this.txt_cUsername.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cUsername.Location = new System.Drawing.Point(346, 191);
            this.txt_cUsername.Name = "txt_cUsername";
            this.txt_cUsername.Size = new System.Drawing.Size(190, 28);
            this.txt_cUsername.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_cUsername, "Input Admin\'s current username");
            // 
            // txt_cPassword
            // 
            this.txt_cPassword.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cPassword.Location = new System.Drawing.Point(346, 228);
            this.txt_cPassword.Name = "txt_cPassword";
            this.txt_cPassword.Size = new System.Drawing.Size(190, 28);
            this.txt_cPassword.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_cPassword, "Input Admin\'s current password");
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.ForeColor = System.Drawing.Color.Green;
            this.radLabel2.Location = new System.Drawing.Point(169, 229);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(176, 27);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Current Password:";
            // 
            // btn_resetLogin
            // 
            this.btn_resetLogin.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetLogin.ForeColor = System.Drawing.Color.Green;
            this.btn_resetLogin.Location = new System.Drawing.Point(346, 278);
            this.btn_resetLogin.Name = "btn_resetLogin";
            this.btn_resetLogin.Size = new System.Drawing.Size(190, 60);
            this.btn_resetLogin.TabIndex = 3;
            this.btn_resetLogin.Text = "Reset Login";
            this.toolTip1.SetToolTip(this.btn_resetLogin, "Reset Admin\'s Login");
            this.btn_resetLogin.Click += new System.EventHandler(this.btn_resetLogin_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.Location = new System.Drawing.Point(25, 5);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(123, 108);
            this.btn_home.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_home, "To Administrator\'s Privileges");
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // ResetLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 500);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_resetLogin);
            this.Controls.Add(this.txt_cPassword);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txt_cUsername);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetLogin";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Login";
            this.ThemeName = "Windows8";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_resetLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txt_cUsername;
        private Telerik.WinControls.UI.RadTextBox txt_cPassword;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btn_resetLogin;
        private CircularButtons btn_home;
        private System.Windows.Forms.ToolTip toolTip1;


    }
}
