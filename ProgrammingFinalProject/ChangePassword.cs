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
    public partial class ChangePassword : Telerik.WinControls.UI.RadForm
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ES1-311\Desktop\MyDataBase\DataBases.accdb");
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form4 = new RadForm4();
            form4.ShowDialog();
        }

        private void chk_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_showPass.Checked)
            {
                txt_confirmNewPassword.PasswordChar = '\0';
                txt_cPassword.PasswordChar = '\0';
                txt_nPassword.PasswordChar = '\0';
            }
            else
            {
                txt_nPassword.PasswordChar = '•';
                txt_cPassword.PasswordChar = '•';
                txt_confirmNewPassword.PasswordChar = '•';
            }
            
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            try
            {
                string cpass = txt_cPassword.Text;
                string npass = txt_nPassword.Text;
                string conNewpass = txt_confirmNewPassword.Text;
                connection.Open();
                OleDbCommand cmd = new OleDbCommand("select Admin.Password from Admin", connection);
                string gotPass = cmd.ExecuteScalar().ToString();
                connection.Close();
                if (gotPass == cpass)
                {
                    if (npass.Length >= 5)
                    {
                        connection.Open();
                        OleDbCommand cmd2 = new OleDbCommand("update Admin set Admin.Password = '" + npass + "' where Admin.Password = '" + cpass + "'", connection);
                        cmd2.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Password was successfully updated. You will now be redirected to Admin Privileges.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Form form4 = new RadForm4();
                        form4.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Password needs to be 5 digits and above.","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_confirmNewPassword.Text = txt_cPassword.Text = txt_nPassword.Text = "";
                        connection.Close();
                    }
                }
            }
            catch(OleDbException)
            {
                MessageBox.Show("One of the required field is empty or incorrect.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_confirmNewPassword.Text = txt_cPassword.Text = txt_nPassword.Text = "";
                connection.Close();
            }
            catch (Exception message)
            {
                MessageBox.Show("Error: " + message);
                txt_confirmNewPassword.Text = txt_cPassword.Text = txt_nPassword.Text = "";
                connection.Close();
            }

        }
    }
}
