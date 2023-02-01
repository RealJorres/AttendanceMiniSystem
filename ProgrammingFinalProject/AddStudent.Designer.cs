namespace ProgrammingFinalProject
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txt_studentName = new Telerik.WinControls.UI.RadTextBox();
            this.txt_studentID = new Telerik.WinControls.UI.RadTextBox();
            this.btn_AddRecord = new Telerik.WinControls.UI.RadButton();
            this.btn_home = new ProgrammingFinalProject.CircularButtons();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_studentName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_studentID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddRecord)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.Green;
            this.radLabel1.Location = new System.Drawing.Point(133, 292);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(114, 27);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "ID Number:";
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.ForeColor = System.Drawing.Color.Green;
            this.radLabel2.Location = new System.Drawing.Point(95, 242);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(152, 27);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Student\'s Name:";
            // 
            // txt_studentName
            // 
            this.txt_studentName.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_studentName.Location = new System.Drawing.Point(253, 241);
            this.txt_studentName.Name = "txt_studentName";
            this.txt_studentName.Size = new System.Drawing.Size(312, 28);
            this.txt_studentName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_studentName, "Input student\'s fullname");
            // 
            // txt_studentID
            // 
            this.txt_studentID.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_studentID.Location = new System.Drawing.Point(253, 291);
            this.txt_studentID.Name = "txt_studentID";
            this.txt_studentID.Size = new System.Drawing.Size(153, 28);
            this.txt_studentID.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txt_studentID, "Input student\'s ID number");
            // 
            // btn_AddRecord
            // 
            this.btn_AddRecord.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddRecord.ForeColor = System.Drawing.Color.Green;
            this.btn_AddRecord.Location = new System.Drawing.Point(253, 348);
            this.btn_AddRecord.Name = "btn_AddRecord";
            this.btn_AddRecord.Size = new System.Drawing.Size(153, 53);
            this.btn_AddRecord.TabIndex = 4;
            this.btn_AddRecord.Text = "Add Student";
            this.toolTip1.SetToolTip(this.btn_AddRecord, "Add student\'s record to Database");
            this.btn_AddRecord.Click += new System.EventHandler(this.btn_AddRecord_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_home.BackgroundImage = global::ProgrammingFinalProject.Properties.Resources.New2;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.Location = new System.Drawing.Point(26, 7);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(120, 106);
            this.btn_home.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_home, "To Administrator\'s Privileges");
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_status);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(585, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(6, 26);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 16);
            this.lbl_status.TabIndex = 6;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_AddRecord);
            this.Controls.Add(this.txt_studentID);
            this.Controls.Add(this.txt_studentName);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStudent";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student Record";
            this.ThemeName = "Windows8";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_studentName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_studentID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddRecord)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txt_studentName;
        private Telerik.WinControls.UI.RadTextBox txt_studentID;
        private Telerik.WinControls.UI.RadButton btn_AddRecord;
        private CircularButtons btn_home;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
