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
    public partial class RadForm3 : Telerik.WinControls.UI.RadForm
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ES1-311\Desktop\MyDataBase\DataBases.accdb");
        public RadForm3()
        {
            InitializeComponent();
        }

        private void chk_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_showPass.Checked)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '•';
            }
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new RadForm2();
            form2.ShowDialog();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = new RadForm1();
            form1.ShowDialog();
        }

        private void btn_adminLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand cmd = new OleDbCommand("select Username from Admin", connection);
            cmd.ExecuteNonQuery();
            string userfromDB = cmd.ExecuteScalar().ToString();
            connection.Close();
            if (userfromDB == txt_username.Text)
            {
                connection.Open();
                OleDbCommand cmd2 = new OleDbCommand("select Password from Admin", connection);
                cmd2.ExecuteNonQuery();
                string passfromDb = cmd2.ExecuteScalar().ToString();
                connection.Close();
                if (passfromDb == txt_password.Text)
                {
                    this.Hide();
                    Form form4 = new RadForm4();
                    form4.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong either Username or Password.","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }

            }
            else
            {
                MessageBox.Show("Wrong either Username or Password.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }
    }
}
