namespace ProgrammingFinalProject
{
    partial class DeleteEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteEvent));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txt_eventName = new Telerik.WinControls.UI.RadTextBox();
            this.btn_deleteEvent = new Telerik.WinControls.UI.RadButton();
            this.btn_home = new ProgrammingFinalProject.CircularButtons();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_eventName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deleteEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.Green;
            this.radLabel1.Location = new System.Drawing.Point(224, 178);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(120, 27);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Event name:";
            // 
            // txt_eventName
            // 
            this.txt_eventName.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eventName.Location = new System.Drawing.Point(344, 173);
            this.txt_eventName.Name = "txt_eventName";
            this.txt_eventName.Size = new System.Drawing.Size(166, 28);
            this.txt_eventName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_eventName, "Input event name");
            // 
            // btn_deleteEvent
            // 
            this.btn_deleteEvent.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteEvent.ForeColor = System.Drawing.Color.Green;
            this.btn_deleteEvent.Location = new System.Drawing.Point(344, 231);
            this.btn_deleteEvent.Name = "btn_deleteEvent";
            this.btn_deleteEvent.Size = new System.Drawing.Size(166, 48);
            this.btn_deleteEvent.TabIndex = 3;
            this.btn_deleteEvent.Text = "Delete Event";
            this.toolTip1.SetToolTip(this.btn_deleteEvent, "Delete Event");
            this.btn_deleteEvent.Click += new System.EventHandler(this.btn_deleteEvent_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackgroundImage = global::ProgrammingFinalProject.Properties.Resources.New2;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_home.Location = new System.Drawing.Point(25, 6);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(122, 109);
            this.btn_home.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_home, "To Administrator\'s Privileges");
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // DeleteEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 500);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_deleteEvent);
            this.Controls.Add(this.txt_eventName);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeleteEvent";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Event";
            this.ThemeName = "Windows8";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_eventName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deleteEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txt_eventName;
        private Telerik.WinControls.UI.RadButton btn_deleteEvent;
        private CircularButtons btn_home;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
