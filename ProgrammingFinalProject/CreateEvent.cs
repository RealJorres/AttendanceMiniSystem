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
    public partial class CreateEvent : Telerik.WinControls.UI.RadForm
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ES1-311\Desktop\MyDataBase\DataBases.accdb");
        public CreateEvent()
        {
            InitializeComponent();
        }

        private void btn_createEvent_Click(object sender, EventArgs e)
        {
            string eventName = txt_eventName.Text;
            if (eventName.Length > 0)
            {
                try
                {

                    int penaltyFee = Convert.ToInt32(txt_penaltyFee.Text);
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand("select * into " + eventName + " from Student", connection);
                    cmd.ExecuteNonQuery();
                    OleDbCommand cmd2 = new OleDbCommand("update " + eventName + " set " + eventName + ".AM_TimeIn = '" + penaltyFee + "', " + eventName + ".AM_TimeOut = '" + penaltyFee + "'," + eventName + ".PM_TimeIn = '" + penaltyFee + "'," + eventName + ".PM_TimeOut = '" + penaltyFee + "'", connection);
                    cmd2.ExecuteNonQuery();
                    connection.Close();
                    eventName.ToUpperInvariant();
                    MessageBox.Show("Event successfully created.\nEvent's name: " + eventName + "\n\nYou will be redirected to Admin Privileges.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form form4 = new RadForm4();
                    form4.ShowDialog();
                }
                catch (OleDbException)
                {
                    MessageBox.Show("The Event Name that you provided is already exists.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("The field for Penalty Fee is empty.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("The field for Event Name is empty.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
