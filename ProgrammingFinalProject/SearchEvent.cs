using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.OleDb;

namespace ProgrammingFinalProject
{
    public partial class SearchEvent : Telerik.WinControls.UI.RadForm
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ES1-311\Desktop\MyDataBase\DataBases.accdb");
        public SearchEvent()
        {
            InitializeComponent();
            lbl_message.Text = "Name:\nPenalty Fees:";
            txt_searchID.Enabled = false;
        }

        private void txt_searchID_Click(object sender, EventArgs e)
        {
            try
            {
                string eventName = txt_eventName.Text;
                string ID = txt_IDnumber.Text;
                connection.Open();
                OleDbCommand cmd_amin = new OleDbCommand("select AM_TimeIn from "+eventName+" where IDnumber = '"+ID+"'", connection);
                cmd_amin.ExecuteNonQuery();
                string AMin = cmd_amin.ExecuteScalar().ToString();
                OleDbCommand cmd_amout = new OleDbCommand("select AM_TimeOut from "+eventName+" where IDnumber = '"+ID+"'", connection);
                cmd_amout.ExecuteNonQuery();
                string AMout = cmd_amout.ExecuteScalar().ToString();
                OleDbCommand cmd_pmin = new OleDbCommand("select PM_TimeIn from "+eventName+" where IDnumber = '"+ID+"'", connection);
                cmd_pmin.ExecuteNonQuery();
                string PMin = cmd_pmin.ExecuteScalar().ToString();
                OleDbCommand cmd_pmout = new OleDbCommand("select PM_TimeOut from "+eventName+" where IDnumber = '"+ID+"'", connection);
                cmd_pmout.ExecuteNonQuery();
                string PMout = cmd_pmout.ExecuteScalar().ToString();
                OleDbCommand cmd2 = new OleDbCommand("select studentName from "+eventName+" where IDnumber = '"+ID+"'", connection);
                cmd2.ExecuteNonQuery();
                string name = cmd2.ExecuteScalar().ToString();
                connection.Close();
                int totalFees = Convert.ToInt32(AMin) + Convert.ToInt32(AMout) + Convert.ToInt32(PMin) + Convert.ToInt32(PMout);
                if (totalFees > 0)
                {
                    btn_payFees.Visible = true;
                }
                else
                {
                    btn_payFees.Visible = false;
                }
                string Pfees = "AM_In    = ₱" + AMin + "\nAM_Out = ₱" + AMout + "\nPM_In    = ₱" + PMin + "\nPM_Out  = ₱" + PMout + "";
                lbl_message.Text = "Name: " + name + "\nPenalty Fees:";
                lbl_penaltyFees.Text = Pfees + "\n______________________\nTotal Fees: ₱"+ totalFees;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("The ID was not registered as a SICS student.", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_IDnumber.Text = "";
                connection.Close();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Event is either empty or doesn't exists.","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form4 = new RadForm4();
            form4.ShowDialog();
        }

        private void txt_IDnumber_Click(object sender, EventArgs e)
        {
            lbl_message.Text = "Name:\nPenalty Fees:";
        }

        private void txt_IDnumber_TextChanged(object sender, EventArgs e)
        {
            if (txt_IDnumber.Text.Length == 7)
            {
                txt_searchID.Enabled = true;
            }
            else
            {
                txt_searchID.Enabled = false;
            }
        }

        private void btn_payFees_Click(object sender, EventArgs e)
        {
            connection.Open();
            string eventName = txt_eventName.Text;
            string ID = txt_IDnumber.Text;
            OleDbCommand cmd1 = new OleDbCommand("update "+eventName+" set AM_TimeIn = 0, AM_TimeOut = 0, PM_TimeIn = 0, PM_TimeOut = 0 where "+eventName+".IDnumber = '"+ID+"'", connection);
            cmd1.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Penalty Fees was removed and successfully updated in the database.\nThank you!","Penalty Fees Cleared!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_IDnumber.Text = "";
        }
    }
}
