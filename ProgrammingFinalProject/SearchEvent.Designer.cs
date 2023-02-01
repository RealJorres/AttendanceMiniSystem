namespace ProgrammingFinalProject
{
    partial class SearchEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchEvent));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txt_eventName = new Telerik.WinControls.UI.RadTextBox();
            this.txt_searchID = new Telerik.WinControls.UI.RadButton();
            this.txt_IDnumber = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.lbl_message = new Telerik.WinControls.UI.RadLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_penaltyFees = new Telerik.WinControls.UI.RadLabel();
            this.btn_payFees = new Telerik.WinControls.UI.RadButton();
            this.btn_home = new ProgrammingFinalProject.CircularButtons();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_eventName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_searchID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IDnumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_penaltyFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_payFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.Green;
            this.radLabel1.Location = new System.Drawing.Point(166, 211);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(120, 27);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Event name:";
            // 
            // txt_eventName
            // 
            this.txt_eventName.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eventName.Location = new System.Drawing.Point(292, 210);
            this.txt_eventName.Name = "txt_eventName";
            this.txt_eventName.Size = new System.Drawing.Size(174, 28);
            this.txt_eventName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_eventName, "Input existing MSC/SICS event");
            // 
            // txt_searchID
            // 
            this.txt_searchID.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchID.ForeColor = System.Drawing.Color.Green;
            this.txt_searchID.Location = new System.Drawing.Point(292, 291);
            this.txt_searchID.Name = "txt_searchID";
            this.txt_searchID.Size = new System.Drawing.Size(174, 58);
            this.txt_searchID.TabIndex = 1;
            this.txt_searchID.Text = "Search";
            this.toolTip1.SetToolTip(this.txt_searchID, "Search");
            this.txt_searchID.Click += new System.EventHandler(this.txt_searchID_Click);
            // 
            // txt_IDnumber
            // 
            this.txt_IDnumber.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDnumber.Location = new System.Drawing.Point(292, 255);
            this.txt_IDnumber.Name = "txt_IDnumber";
            this.txt_IDnumber.Size = new System.Drawing.Size(174, 28);
            this.txt_IDnumber.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_IDnumber, "Input student\'s ID number");
            this.txt_IDnumber.TextChanged += new System.EventHandler(this.txt_IDnumber_TextChanged);
            this.txt_IDnumber.Click += new System.EventHandler(this.txt_IDnumber_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.ForeColor = System.Drawing.Color.Green;
            this.radLabel2.Location = new System.Drawing.Point(166, 256);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(114, 27);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "ID Number:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.radGroupBox1.Controls.Add(this.btn_payFees);
            this.radGroupBox1.Controls.Add(this.lbl_penaltyFees);
            this.radGroupBox1.Controls.Add(this.lbl_message);
            this.radGroupBox1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.ForeColor = System.Drawing.Color.Green;
            this.radGroupBox1.HeaderText = "Status Message";
            this.radGroupBox1.Location = new System.Drawing.Point(506, 169);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(279, 180);
            this.radGroupBox1.TabIndex = 3;
            this.radGroupBox1.Text = "Status Message";
            ((Telerik.WinControls.UI.RadGroupBoxElement)(this.radGroupBox1.GetChildAt(0))).InvalidateMeasureInMainLayout = 4;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(1))).BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(1))).InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(211)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(192)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            // 
            // lbl_message
            // 
            this.lbl_message.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.ForeColor = System.Drawing.Color.Green;
            this.lbl_message.Location = new System.Drawing.Point(17, 44);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(2, 2);
            this.lbl_message.TabIndex = 1;
            // 
            // lbl_penaltyFees
            // 
            this.lbl_penaltyFees.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_penaltyFees.ForeColor = System.Drawing.Color.Green;
            this.lbl_penaltyFees.Location = new System.Drawing.Point(39, 77);
            this.lbl_penaltyFees.Name = "lbl_penaltyFees";
            this.lbl_penaltyFees.Size = new System.Drawing.Size(2, 2);
            this.lbl_penaltyFees.TabIndex = 2;
            // 
            // btn_payFees
            // 
            this.btn_payFees.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payFees.ForeColor = System.Drawing.Color.Green;
            this.btn_payFees.Location = new System.Drawing.Point(194, 145);
            this.btn_payFees.Name = "btn_payFees";
            this.btn_payFees.Size = new System.Drawing.Size(80, 30);
            this.btn_payFees.TabIndex = 2;
            this.btn_payFees.Text = "Pay";
            this.toolTip1.SetToolTip(this.btn_payFees, "Process a Payment");
            this.btn_payFees.Visible = false;
            this.btn_payFees.Click += new System.EventHandler(this.btn_payFees_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_home.BackgroundImage = global::ProgrammingFinalProject.Properties.Resources.New2;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.ForeColor = System.Drawing.Color.Transparent;
            this.btn_home.Location = new System.Drawing.Point(26, 7);
            this.btn_home.Margin = new System.Windows.Forms.Padding(0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(121, 107);
            this.btn_home.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_home, "To Administrator\'s Privileges");
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // SearchEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 500);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.txt_IDnumber);
            this.Controls.Add(this.txt_searchID);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txt_eventName);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchEvent";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Event/ID";
            this.ThemeName = "Windows8";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_eventName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_searchID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IDnumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_penaltyFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_payFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txt_eventName;
        private Telerik.WinControls.UI.RadButton txt_searchID;
        private Telerik.WinControls.UI.RadTextBox txt_IDnumber;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel lbl_message;
        private CircularButtons btn_home;
        private System.Windows.Forms.ToolTip toolTip1;
        private Telerik.WinControls.UI.RadLabel lbl_penaltyFees;
        private Telerik.WinControls.UI.RadButton btn_payFees;
    }
}
