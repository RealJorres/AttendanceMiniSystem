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
    public partial class AddStudent : Telerik.WinControls.UI.RadForm
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ES1-311\Desktop\MyDataBase\DataBases.accdb");
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form4 = new RadForm4();
            form4.ShowDialog();
        }

        private void btn_AddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txt_studentName.Text;
                string ID = txt_studentID.Text;
                ID.ToUpperInvariant();
                if (ID.Length == 7)
                {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand("insert into Student(IDnumber, studentName) values(@0,@1)", connection);
                    cmd.Parameters.AddWithValue("@0", ID);
                    cmd.Parameters.AddWithValue("@1", name);
                    cmd.ExecuteNonQuery();
                    lbl_status.Text = "Record Updated Successfully\nName: " + txt_studentName.Text + "\nIDnumber: " + txt_studentID.Text;
                }
                else
                {
                    MessageBox.Show("MSC ID is 7 digits.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbl_status.Text = "Error! No changes made.";
                }
            }
            catch (OleDbException)
            {
                MessageBox.Show("Name or ID should not be empty.\nDuplicate Entry is not allowed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_status.Text = "Error! No changes made.";
            }
            catch (Exception message)
            {
                MessageBox.Show("Error: " + message);
                lbl_status.Text = "Error! No changes made.";
            }
            finally
            {
                txt_studentID.Text = txt_studentName.Text = "";
                connection.Close();
            }
        }
    }
}
