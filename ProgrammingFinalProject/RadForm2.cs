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
    public partial class RadForm2 : Telerik.WinControls.UI.RadForm
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ES1-311\Desktop\MyDataBase\DataBases.accdb");
        public RadForm2()
        {
            InitializeComponent();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form3 = new RadForm3();
            form3.ShowDialog();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = new RadForm1();
            form1.ShowDialog();
        }

        private void btn_EventLock_Click(object sender, EventArgs e)
        {
            txt_EventName.ReadOnly = true;
            cmb_Time.Enabled = false;
            
        }
        private void txt_IDnumber_TextChanged(object sender, EventArgs e)
        {
            lbl_message.Text = "";
            string idNumber = txt_IDnumber.Text;
            if (idNumber.Length == 7)
            {
                btn_studentLogin.Enabled = true;
            }
            else
            {
                btn_studentLogin.Enabled = false;
            }
        }

        private void btn_studentLogin_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_message.Text = "";
                string eventName = txt_EventName.Text;
                string time = cmb_Time.Text;
                string id = txt_IDnumber.Text.ToUpperInvariant();
                connection.Open();
                OleDbCommand cmd = new OleDbCommand("select studentName from "+eventName+" where IDnumber = @0", connection);
                cmd.Parameters.AddWithValue("@0", id);
                cmd.ExecuteNonQuery();
                OleDbCommand cmd2 = new OleDbCommand("update "+eventName+" set " + time + " = 0 where IDnumber = @0", connection);
                cmd2.Parameters.AddWithValue("@0", id);
                cmd2.ExecuteNonQuery();
                txt_IDnumber.Text = "";
                lbl_message.Text = ("Thank you for logging-in \n" + cmd.ExecuteScalar().ToString());
                connection.Close();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Posible reason:\n  *Event is not existing\n", "Error Encountered!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Reason: ID number does not belong to SICS.","Error Encountered!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }
    }
}
