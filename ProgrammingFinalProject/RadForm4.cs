using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.OleDb;
namespace ProgrammingFinalProject
{
    public partial class RadForm4 : Telerik.WinControls.UI.RadForm
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ES1-311\Desktop\MyDataBase\DataBases.accdb");
        public RadForm4()
        {
            InitializeComponent();
        }

        private void btn_createEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form createEvent = new CreateEvent();
            createEvent.ShowDialog();
        }

        private void btn_deleteEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form deleteEvent = new DeleteEvent();
            deleteEvent.ShowDialog();
        }

        private void btn_searchEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form searchEvent = new SearchEvent();
            searchEvent.ShowDialog();
        }

        private void btn_changeUsername_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form changeUsername = new ChangeUsername();
            changeUsername.ShowDialog();
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }

        private void btn_resetLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form resetLogin = new ResetLogin();
            resetLogin.ShowDialog();
        }

        private void btn_home_Click_1(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to continue?", "Redirecting to Homepage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                this.Hide();
                Form form1 = new RadForm1();
                form1.ShowDialog();
            }
        }

        private void btn_addRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form addRecord = new AddStudent();
            addRecord.ShowDialog();
        }
    }
}
