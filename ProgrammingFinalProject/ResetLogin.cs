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
    public partial class ResetLogin : Telerik.WinControls.UI.RadForm
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ES1-311\Desktop\MyDataBase\DataBases.accdb");
        public ResetLogin()
        {
            InitializeComponent();
        }

        private void btn_resetLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txt_cUsername.Text;
                string password = txt_cPassword.Text;
                if (name.Length >= 5 && password.Length >= 5)
                {
                    DialogResult me = MessageBox.Show("Your are about to reset your logins. Continue?", "Confirmation" , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (me == DialogResult.OK)
                    {
                        connection.Open();
                        OleDbCommand cmd = new OleDbCommand("update Admin set Admin.Username = 'Sicso' where Admin.Username = '" + name + "'", connection);
                        string text = cmd.ExecuteNonQuery().ToString();
                        connection.Close();
                        if (text == "1")
                        {
                            connection.Open();
                            OleDbCommand cmd2 = new OleDbCommand("update Admin set Admin.Password = 'Sicso' where Admin.Username = 'Sicso'", connection);
                            string text2 = cmd2.ExecuteNonQuery().ToString();
                            connection.Close();
                            if (text2 == "1")
                            {
                                MessageBox.Show("Login reset successfully. You will be redirected to Admin Privileges.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Form form4 = new RadForm4();
                                form4.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Either current username or password is incorrect. ", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_cUsername.Text = txt_cPassword.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Either current username or password is incorrect. ", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_cUsername.Text = txt_cPassword.Text = "";
                        }
 
                    }
                    else
                    {
                        MessageBox.Show("Request aborted. No changes has been made.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("One of the field above is empty or incorrect.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
            }
            catch (Exception message)
            {
                MessageBox.Show("Error: " + message);
                connection.Close();
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
