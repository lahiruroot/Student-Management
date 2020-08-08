using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentRegSys
{
    public partial class Modules : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\SUDB.mdf; Integrated Security = True; Connect Timeout = 30");
        private SqlCommand cmd;
        string user;
        public List<string> modulelist { get; set; }

        public Modules(string id)
        {
            user = id;
            InitializeComponent();
        }

        private void Modules_Load(object sender, EventArgs e)
        {
            btnClose.AutoSize = false;
            btnSave.AutoSize = false;
            btnSave.Width = 100;
            btnClose.Width = 100;

            try
            {
                cmd = new SqlCommand("select MId from Module", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    lbxAvailable.Items.Add(reader.GetString(0));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving data from Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

            if(user.Length>0 && !user.Contains(" ")) { 
            try
            {
                cmd = new SqlCommand("select MId from Module_Prof where PId="+user, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string tmp = reader.GetString(0);
                    lbxSelected.Items.Add(tmp);
                    lbxAvailable.Items.Remove(tmp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving data from Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbxAvailable.SelectedIndex > -1)
            {
                lbxSelected.Items.Add(lbxAvailable.SelectedItem);
                lbxAvailable.Items.Remove(lbxAvailable.SelectedItem);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbxSelected.SelectedIndex > -1)
            {
                lbxAvailable.Items.Add(lbxSelected.SelectedItem);
                lbxSelected.Items.Remove(lbxSelected.SelectedItem);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            modulelist = new List<string>();
            foreach (string x in lbxSelected.Items)
                this.modulelist.Add(x);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
