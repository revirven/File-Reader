using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FileLab
{
    public partial class sqlLogin : Form
    {
        public sqlLogin()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ServerName_TextChanged(object sender, EventArgs e)
        {
            login.dataSource = ServerName.Text;
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            login.userName = UserName.Text;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            login.userPassword = Password.Text;
        }
        private void UserDatabase_TextChanged(object sender, EventArgs e)
        {
            login.userDatabase = UserDatabase.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ServerName.Enabled = true;
            UserName.Enabled = true;
            Password.Enabled = true;
            UserDatabase.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ServerName.Enabled = true;
            UserName.Enabled = false;
            Password.Enabled = false;
            UserDatabase.Enabled = true;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (ServerName.Text == "" || UserDatabase.Text == "" || UserName.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("All fields are required and must not be empty.", "Warning");
                }
                else
                {
                    try
                    {
                        string StrConnect = "Data Source = " + login.dataSource + "; " + "Initial Catalog = " + login.userDatabase + "; " + "User ID = " + login.userName + "; " + "Password = " + login.userPassword;
                        sqlConnect.connection = new SqlConnection(StrConnect);
                        DatabaseExport dataExport = new DatabaseExport();
                        dataExport.FormClosed += new FormClosedEventHandler(dataExport_FormClosed);
                        this.Hide();
                        dataExport.Show();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString(), "Error");
                        return;
                    }
                }
            }
            else
            {
                if (ServerName.Text == "" || UserDatabase.Text == "")
                {
                    MessageBox.Show("Server name and Default database are required and must not be empty.", "Warning");
                }
                else
                {
                    try
                    {
                        string StrConnect = "Data Source = " + login.dataSource + "; " + "Initial Catalog = " + login.userDatabase + "; " + "Integrated Security = SSPI";
                        sqlConnect.connection = new SqlConnection(StrConnect);
                        DatabaseExport dataExport = new DatabaseExport();
                        dataExport.FormClosed += new FormClosedEventHandler(dataExport_FormClosed);
                        this.Hide();
                        dataExport.Show();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString(), "Error");
                        return;
                    }
                }    
            }
        }

        private void dataExport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            sqlConnect.connection.Close();
        }
    }
}
