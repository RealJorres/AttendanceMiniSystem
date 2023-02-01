namespace ProgrammingFinalProject
{
    partial class ChangeUsername
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUsername));
            this.btn_home = new ProgrammingFinalProject.CircularButtons();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cUsername = new System.Windows.Forms.TextBox();
            this.btn_changeUsername = new Telerik.WinControls.UI.RadButton();
            this.txt_nUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_showPass = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btn_changeUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_home.BackgroundImage = global::ProgrammingFinalProject.Properties.Resources.New2;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.Location = new System.Drawing.Point(26, 7);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(123, 108);
            this.btn_home.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_home, "To Administrator\'s Privileges");
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(106, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current Username:";
            // 
            // txt_cUsername
            // 
            this.txt_cUsername.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cUsername.Location = new System.Drawing.Point(291, 195);
            this.txt_cUsername.Name = "txt_cUsername";
            this.txt_cUsername.Size = new System.Drawing.Size(202, 30);
            this.txt_cUsername.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txt_cUsername, "Input Admin\'s current username");
            // 
            // btn_changeUsername
            // 
            this.btn_changeUsername.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changeUsername.ForeColor = System.Drawing.Color.Green;
            this.btn_changeUsername.Location = new System.Drawing.Point(291, 335);
            this.btn_changeUsername.Name = "btn_changeUsername";
            this.btn_changeUsername.Size = new System.Drawing.Size(202, 63);
            this.btn_changeUsername.TabIndex = 8;
            this.btn_changeUsername.Text = "Change Username";
            this.toolTip1.SetToolTip(this.btn_changeUsername, "Change Username");
            this.btn_changeUsername.Click += new System.EventHandler(this.btn_changeUsername_Click);
            // 
            // txt_nUsername
            // 
            this.txt_nUsername.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nUsername.Location = new System.Drawing.Point(291, 231);
            this.txt_nUsername.Name = "txt_nUsername";
            this.txt_nUsername.Size = new System.Drawing.Size(202, 30);
            this.txt_nUsername.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txt_nUsername, "Input Admin\'s new username");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(135, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "New Username:";
            // 
            // txt_cPassword
            // 
            this.txt_cPassword.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cPassword.Location = new System.Drawing.Point(291, 268);
            this.txt_cPassword.Name = "txt_cPassword";
            this.txt_cPassword.PasswordChar = '•';
            this.txt_cPassword.Size = new System.Drawing.Size(202, 30);
            this.txt_cPassword.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txt_cPassword, "Input Admin\'s password for confirmation");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(107, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Confirm Password:";
            // 
            // chk_showPass
            // 
            this.chk_showPass.AutoSize = true;
            this.chk_showPass.BackColor = System.Drawing.Color.Transparent;
            this.chk_showPass.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_showPass.ForeColor = System.Drawing.Color.Green;
            this.chk_showPass.Location = new System.Drawing.Point(291, 304);
            this.chk_showPass.Name = "chk_showPass";
            this.chk_showPass.Size = new System.Drawing.Size(117, 20);
            this.chk_showPass.TabIndex = 13;
            this.chk_showPass.Text = "Show Password";
            this.toolTip1.SetToolTip(this.chk_showPass, "Show/Hide password");
            this.chk_showPass.UseVisualStyleBackColor = false;
            this.chk_showPass.CheckedChanged += new System.EventHandler(this.chk_showPass_CheckedChanged);
            // 
            // ChangeUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 500);
            this.Controls.Add(this.chk_showPass);
            this.Controls.Add(this.txt_cPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_changeUsername);
            this.Controls.Add(this.txt_cUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_home);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangeUsername";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Username";
            this.ThemeName = "Windows8";
            ((System.ComponentModel.ISupportInitialize)(this.btn_changeUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularButtons btn_home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cUsername;
        private Telerik.WinControls.UI.RadButton btn_changeUsername;
        private System.Windows.Forms.TextBox txt_nUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_showPass;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
