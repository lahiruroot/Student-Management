using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegSys
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnLogin.AutoSize = false;
            btnLogin.Width = 100;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.ToLower();
            string pwd = txtPassword.Text;
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\SUDB.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlCommand cmd = new SqlCommand("select count(Id) from Auth where Username='" + user + "'", con);
            int UserExist;

            try
            {
                con.Open();
                UserExist = (int)cmd.ExecuteScalar();
                con.Close();

                if (UserExist < 1)
                    MessageBox.Show("The username you entered is not registered. Please contact the Registrar’s office.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    cmd = new SqlCommand("select Password from Auth where Username='" + user + "'", con);
                    con.Open();
                    string pass = cmd.ExecuteScalar().ToString();
                    con.Close();
                    if (pass != pwd)
                        MessageBox.Show("The password you entered is invalid. Please contact the Registrar’s office if you have forgotten your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        cmd = new SqlCommand("select Id,Type from Auth where Username='" + user + "'", con);
                        int type, Id;
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            type = (byte)reader["Type"];
                            Id = (int)reader["Id"];
                        }
                        con.Close();

                        this.Hide();
                        if (type == 0)
                        {
                            Main main = new Main(Id);
                            main.ShowDialog();
                        }
                       
                        else if (type == 2)
                        {
                            Professor professor = new Professor(Id);
                            professor.ShowDialog();
                        }
                        this.Close();
                    }
                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
