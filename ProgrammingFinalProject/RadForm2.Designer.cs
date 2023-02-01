namespace ProgrammingFinalProject
{
    partial class RadForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm2));
            this.btn_home = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_admin = new Telerik.WinControls.UI.RadButton();
            this.btn_student = new Telerik.WinControls.UI.RadButton();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_EventLock = new Telerik.WinControls.UI.RadButton();
            this.txt_IDnumber = new System.Windows.Forms.TextBox();
            this.btn_studentLogin = new Telerik.WinControls.UI.RadButton();
            this.txt_EventName = new System.Windows.Forms.TextBox();
            this.pnl_student = new Telerik.WinControls.UI.RadPanel();
            this.cmb_Time = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grb_message = new System.Windows.Forms.GroupBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EventLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_studentLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_student)).BeginInit();
            this.pnl_student.SuspendLayout();
            this.grb_message.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.Green;
            this.btn_home.Image = global::ProgrammingFinalProject.Properties.Resources.appbar_home_variant;
            this.btn_home.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btn_home.Location = new System.Drawing.Point(0, 226);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(237, 82);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "Home";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btn_home, "Home Page");
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_home.GetChildAt(0))).Image = global::ProgrammingFinalProject.Properties.Resources.appbar_home_variant;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_home.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_home.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_home.GetChildAt(0))).Text = "Home";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn_home.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(149)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn_home.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(78)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn_home.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn_home.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btn_home.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            // 
            // radPanel1
            // 
            this.radPanel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.radPanel1.BackColor = System.Drawing.Color.Green;
            this.radPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radPanel1.Controls.Add(this.pictureBox1);
            this.radPanel1.Controls.Add(this.btn_home);
            this.radPanel1.Controls.Add(this.btn_admin);
            this.radPanel1.Controls.Add(this.btn_student);
            this.radPanel1.Location = new System.Drawing.Point(1, 2);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(237, 500);
            this.radPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProgrammingFinalProject.Properties.Resources.Untitled_2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 200);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_admin
            // 
            this.btn_admin.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.ForeColor = System.Drawing.Color.Green;
            this.btn_admin.Image = global::ProgrammingFinalProject.Properties.Resources.appbar_group;
            this.btn_admin.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btn_admin.Location = new System.Drawing.Point(0, 314);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(237, 82);
            this.btn_admin.TabIndex = 3;
            this.btn_admin.Text = "Admin";
            this.btn_admin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btn_admin, "Admin Page");
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_admin.GetChildAt(0))).Image = global::ProgrammingFinalProject.Properties.Resources.appbar_group;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_admin.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_admin.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_admin.GetChildAt(0))).Text = "Admin";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn_admin.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(147)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn_admin.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(78)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn_admin.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn_admin.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btn_admin.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            // 
            // btn_student
            // 
            this.btn_student.Enabled = false;
            this.btn_student.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student.ForeColor = System.Drawing.Color.Green;
            this.btn_student.Image = global::ProgrammingFinalProject.Properties.Resources.appbar_people;
            this.btn_student.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btn_student.Location = new System.Drawing.Point(0, 402);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(237, 82);
            this.btn_student.TabIndex = 4;
            this.btn_student.Text = "Student";
            this.btn_student.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btn_student, "Student Page (Current)");
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_student.GetChildAt(0))).Image = global::ProgrammingFinalProject.Properties.Resources.appbar_people;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_student.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_student.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_student.GetChildAt(0))).Text = "Student";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn_student.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(147)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn_student.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(78)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn_student.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn_student.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btn_student.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            // 
            // btn_EventLock
            // 
            this.btn_EventLock.Font = new System.Drawing.Font("Rockwell", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EventLock.ForeColor = System.Drawing.Color.Green;
            this.btn_EventLock.Location = new System.Drawing.Point(330, 170);
            this.btn_EventLock.Name = "btn_EventLock";
            this.btn_EventLock.Size = new System.Drawing.Size(33, 30);
            this.btn_EventLock.TabIndex = 8;
            this.btn_EventLock.Text = "Lock";
            this.toolTip1.SetToolTip(this.btn_EventLock, "Set the event name\'s field to ReadOnly");
            this.btn_EventLock.Click += new System.EventHandler(this.btn_EventLock_Click);
            // 
            // txt_IDnumber
            // 
            this.txt_IDnumber.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDnumber.Location = new System.Drawing.Point(146, 256);
            this.txt_IDnumber.Name = "txt_IDnumber";
            this.txt_IDnumber.Size = new System.Drawing.Size(179, 30);
            this.txt_IDnumber.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txt_IDnumber, "Enter ID number of student");
            this.txt_IDnumber.TextChanged += new System.EventHandler(this.txt_IDnumber_TextChanged);
            // 
            // btn_studentLogin
            // 
            this.btn_studentLogin.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_studentLogin.ForeColor = System.Drawing.Color.Green;
            this.btn_studentLogin.Location = new System.Drawing.Point(146, 292);
            this.btn_studentLogin.Name = "btn_studentLogin";
            this.btn_studentLogin.Size = new System.Drawing.Size(179, 48);
            this.btn_studentLogin.TabIndex = 1;
            this.btn_studentLogin.Text = "Login";
            this.toolTip1.SetToolTip(this.btn_studentLogin, "Login");
            this.btn_studentLogin.Click += new System.EventHandler(this.btn_studentLogin_Click);
            // 
            // txt_EventName
            // 
            this.txt_EventName.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EventName.Location = new System.Drawing.Point(146, 170);
            this.txt_EventName.Name = "txt_EventName";
            this.txt_EventName.Size = new System.Drawing.Size(179, 30);
            this.txt_EventName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_EventName, "Input existing event\'s name");
            // 
            // pnl_student
            // 
            this.pnl_student.AllowShowFocusCues = true;
            this.pnl_student.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_student.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_student.BackgroundImage")));
            this.pnl_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_student.Controls.Add(this.cmb_Time);
            this.pnl_student.Controls.Add(this.label2);
            this.pnl_student.Controls.Add(this.grb_message);
            this.pnl_student.Controls.Add(this.btn_EventLock);
            this.pnl_student.Controls.Add(this.label1);
            this.pnl_student.Controls.Add(this.txt_IDnumber);
            this.pnl_student.Controls.Add(this.btn_studentLogin);
            this.pnl_student.Controls.Add(this.label3);
            this.pnl_student.Controls.Add(this.txt_EventName);
            this.pnl_student.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_student.Location = new System.Drawing.Point(258, 12);
            this.pnl_student.Name = "pnl_student";
            this.pnl_student.Size = new System.Drawing.Size(530, 475);
            this.pnl_student.TabIndex = 7;
            this.pnl_student.ThemeName = "the";
            // 
            // cmb_Time
            // 
            this.cmb_Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Time.FormattingEnabled = true;
            this.cmb_Time.Items.AddRange(new object[] {
            "AM_TimeIn",
            "AM_TimeOut",
            "PM_TimeIn",
            "PM_TimeOut"});
            this.cmb_Time.Location = new System.Drawing.Point(146, 216);
            this.cmb_Time.Name = "cmb_Time";
            this.cmb_Time.Size = new System.Drawing.Size(121, 21);
            this.cmb_Time.TabIndex = 12;
            this.cmb_Time.Text = "-SELECT-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(80, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Time:";
            // 
            // grb_message
            // 
            this.grb_message.BackColor = System.Drawing.Color.Transparent;
            this.grb_message.Controls.Add(this.lbl_message);
            this.grb_message.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_message.ForeColor = System.Drawing.Color.Green;
            this.grb_message.Location = new System.Drawing.Point(333, 258);
            this.grb_message.Name = "grb_message";
            this.grb_message.Size = new System.Drawing.Size(194, 81);
            this.grb_message.TabIndex = 9;
            this.grb_message.TabStop = false;
            this.grb_message.Text = "Message";
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(18, 24);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 16);
            this.lbl_message.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(27, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(18, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Event Name:";
            // 
            // radButton1
            // 
            this.radButton1.Enabled = false;
            this.radButton1.Location = new System.Drawing.Point(244, 404);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(10, 82);
            this.radButton1.TabIndex = 9;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(147)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(78)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            // 
            // RadForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(797, 500);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.pnl_student);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1, 2);
            this.MaximizeBox = false;
            this.Name = "RadForm2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.ThemeName = "Windows8";
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EventLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_studentLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_student)).EndInit();
            this.pnl_student.ResumeLayout(false);
            this.pnl_student.PerformLayout();
            this.grb_message.ResumeLayout(false);
            this.grb_message.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btn_home;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton btn_admin;
        private Telerik.WinControls.UI.RadButton btn_student;
        private Telerik.WinControls.UI.RadPanel pnl_student;
        private Telerik.WinControls.UI.RadButton btn_studentLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_EventName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadButton btn_EventLock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IDnumber;
        private System.Windows.Forms.GroupBox grb_message;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.ToolTip toolTip1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Time;
    }
}
