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
    public partial class DeleteEvent : Telerik.WinControls.UI.RadForm
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ES1-311\Desktop\MyDataBase\DataBases.accdb");
        public DeleteEvent()
        {
            InitializeComponent();
        }

        private void btn_deleteEvent_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("This event will permanetly deleted. Continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (answer == DialogResult.Yes)
                {
                    string eventName = txt_eventName.Text;
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand("drop table " + eventName, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Successfully deleted.\nEvent name: " + eventName+"\n\nYou will be redirected to Admin Privileges.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form form4 = new RadForm4();
                    form4.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Operation was canceled. No changes made!", "Aborted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("Reason:\n   *Event does not exists\n   *Event name is empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult answer = MessageBox.Show("Return to Administrator Privileges?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    this.Hide();
                    Form form4 = new RadForm4();
                    form4.ShowDialog();
                }
                txt_eventName.Text = "";
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form4 = new RadForm4();
            form4.ShowDialog();
        }
    }
}
