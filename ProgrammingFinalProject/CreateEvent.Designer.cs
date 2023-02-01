namespace ProgrammingFinalProject
{
    partial class CreateEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEvent));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txt_eventName = new Telerik.WinControls.UI.RadTextBox();
            this.btn_createEvent = new Telerik.WinControls.UI.RadButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_penaltyFee = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btn_home = new ProgrammingFinalProject.CircularButtons();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_eventName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_createEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_penaltyFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.Green;
            this.radLabel1.Location = new System.Drawing.Point(226, 183);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(120, 27);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Event name:";
            // 
            // txt_eventName
            // 
            this.txt_eventName.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eventName.Location = new System.Drawing.Point(343, 179);
            this.txt_eventName.Name = "txt_eventName";
            this.txt_eventName.Size = new System.Drawing.Size(166, 28);
            this.txt_eventName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_eventName, "Input event name");
            // 
            // btn_createEvent
            // 
            this.btn_createEvent.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createEvent.ForeColor = System.Drawing.Color.Green;
            this.btn_createEvent.Location = new System.Drawing.Point(343, 278);
            this.btn_createEvent.Name = "btn_createEvent";
            this.btn_createEvent.Size = new System.Drawing.Size(166, 48);
            this.btn_createEvent.TabIndex = 1;
            this.btn_createEvent.Text = "Create Event";
            this.toolTip1.SetToolTip(this.btn_createEvent, "Create Event");
            this.btn_createEvent.Click += new System.EventHandler(this.btn_createEvent_Click);
            // 
            // txt_penaltyFee
            // 
            this.txt_penaltyFee.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_penaltyFee.Location = new System.Drawing.Point(343, 213);
            this.txt_penaltyFee.Name = "txt_penaltyFee";
            this.txt_penaltyFee.Size = new System.Drawing.Size(166, 28);
            this.txt_penaltyFee.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_penaltyFee, "Input event\'s penalty fee per sign-in (AM Time-in/out & PM Time-in/out )\r\n\r\nNote:" +
        " Penalty Fee is the amount implemented if the student wasn\'t able to sign-in.");
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.ForeColor = System.Drawing.Color.Green;
            this.radLabel2.Location = new System.Drawing.Point(224, 214);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(119, 27);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Penalty Fee:";
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_home.BackgroundImage = global::ProgrammingFinalProject.Properties.Resources.New2;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.Location = new System.Drawing.Point(26, 8);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(122, 105);
            this.btn_home.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_home, "To Administrator\'s Privileges");
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // CreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 500);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txt_penaltyFee);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_createEvent);
            this.Controls.Add(this.txt_eventName);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateEvent";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Event";
            this.ThemeName = "Windows8";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_eventName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_createEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_penaltyFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txt_eventName;
        private Telerik.WinControls.UI.RadButton btn_createEvent;
        private CircularButtons btn_home;
        private System.Windows.Forms.ToolTip toolTip1;
        private Telerik.WinControls.UI.RadTextBox txt_penaltyFee;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}
