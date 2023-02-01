using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgrammingFinalProject
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            gbx_MscMission.Visible = gbx_MscVision.Visible = gbx_SicsGoal.Visible = false;
            picHome.Visible = true;
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form3 = new RadForm3();
            form3.ShowDialog();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new RadForm2();
            form2.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picHome.Visible = true;
            gbx_MscMission.Visible = gbx_MscVision.Visible = gbx_SicsGoal.Visible = false;
        }

        private void mSCMissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picHome.Visible = false;
            gbx_MscMission.Visible = true;
            gbx_MscVision.Visible = gbx_SicsGoal.Visible = false;
        }

        private void mSCVISIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picHome.Visible = false;
            gbx_MscVision.Visible = true;
            gbx_MscMission.Visible = gbx_SicsGoal.Visible = false;
        }

        private void sICSGOALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picHome.Visible = false;
            gbx_SicsGoal.Visible = true;
            gbx_MscMission.Visible = gbx_MscVision.Visible = false;
        }
    }
}
