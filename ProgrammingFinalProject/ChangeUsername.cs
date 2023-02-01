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
    public partial class ChangeUsername : Telerik.WinControls.UI.RadForm
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ES1-311\Desktop\MyDataBase\DataBases.accdb");
        public ChangeUsername()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form4 = new RadForm4();
            form4.ShowDialog();
        }

        private void btn_changeUsername_Click(object sender, EventArgs e)
        {
            try
            {
                string cUser = txt_cUsername.Text;
                string cPass = txt_cPassword.Text;
                string nUser = txt_nUsername.Text;
                if (nUser.Length >= 5 && cUser.Length >= 5 && cPass.Length >= 5)
                {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand("update Admin set Admin.Username = '" + nUser + "' where Admin.Username = '" + cUser + "' and Admin.Password = '" + cPass + "'", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Username was successfully updated. You will now be redirected to Admin Privileges.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form form4 = new RadForm4();
                    form4.ShowDialog();
                }
                else
                {
                    MessageBox.Show("One of the field above is empty or incorrect.","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
            }
            catch (OleDbException)
            {
                MessageBox.Show("One of the required field is empty or incorrect.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            catch (Exception message)
            {
                MessageBox.Show("Error: "+message);
                connection.Close();
            }
        }

        private void chk_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_showPass.Checked)
            {
                txt_cPassword.PasswordChar = '\0';
            }
            else
            {
                txt_cPassword.PasswordChar = '•';
            }
        }
    }
}
