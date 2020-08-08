using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace StudentRegSys
{
    public partial class Professor : MaterialForm
    {
        private int Id;
        private SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\SUDB.mdf; Integrated Security = True; Connect Timeout = 30");
        private SqlCommand cmd;

        public Professor(int user)
        {
            InitializeComponent();
            Id = user;
        }
        private void Student_Load(object sender, System.EventArgs e)
        {
            btnPassword.AutoSize = false;
            btnPassword.Width = 150;
            btnSave.AutoSize = false;
            btnSave.Width = 150;
            
            try
            {
                cmd = new SqlCommand("select * from Professor where PId="+Id, con);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    lblReg.Text = reader["PId"].ToString();
                    lblName.Text = reader["FName"].ToString()+" "+ reader["LName"].ToString();
                    lblGender.Text = (reader["Gender"].ToString().ToLower()=="true") ? "Male" : "Female";
                    lblDOB.Text = reader["DOB"].ToString();
                    lblAddress.Text = reader["Address"].ToString();
                    lblEmail.Text = reader["Email"].ToString();
                    lblPhone.Text = reader["Phone"].ToString();
                    lblQulf.Text = reader["Qualifications"].ToString();
                    lblUsername.Text = reader["Username"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving data from Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            SqlDataAdapter adt = new SqlDataAdapter("select * from Module", con);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                adt.Fill(dt);
                con.Close();
                datagridModule.DataSource = dt;
                for (int i = 0; i < 6; i++)
                    datagridModule.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving data from Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

            try
            {
                cmd = new SqlCommand("select MId from Module", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string tmp = reader.GetString(0);
                    lbxAvailable.Items.Add(tmp);
                    cmbxModule.Items.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving data from Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

            try
            {
                cmd = new SqlCommand("select MId from Module_Prof where PId=" + Id, con);
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

        private void lblYear_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Please contact the Registrar’s office to change your details.", "Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            string pass = "";
            try
            {
                cmd = new SqlCommand("select Password from Auth where Id=" + Id, con);
                con.Open();
                pass = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Changing Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            if (txtCurrent.Text != pass)
                MessageBox.Show("The current password is incorrect. Contact the Registrar’s office if you have forgotten your password.", "Changing Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txtConfirm.Text != txtNew.Text)
                MessageBox.Show("Passwords does not match", "Changing Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txtNew.TextLength < 6)
                MessageBox.Show("Passwords should be longer than 6 characters", "Changing Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                SqlCommand cmd = new SqlCommand("update Auth set Password='" + txtNew.Text + "' where Id=" + Id, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password Changed", "Changing Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Changing Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
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
            try
            {
                cmd = new SqlCommand("delete from Module_Prof where PId=" + Id, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                foreach (string x in lbxSelected.Items)
                {
                    cmd = new SqlCommand("insert into Module_Prof values(" + Id + ",'" + x + "')", con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving data from Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            MessageBox.Show("User record updated.", "Professor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbxSYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxModule.SelectedIndex > -1) {
                string x = cmbxModule.Items[cmbxModule.SelectedIndex].ToString();
                SqlDataAdapter adt = new SqlDataAdapter("select * from Student where Module1='"+x+ "' OR Module2='" + x + "' OR Module3='" + x + "' OR Module4='" + x + "' OR Module5='" + x + "' OR Module6='"+x+"'", con);
                DataTable dt = new DataTable();
                try
                {
                    con.Open();
                    adt.Fill(dt);
                    con.Close();
                    datagridStudent.DataSource = dt;
                    for (int i = 0; i < 6; i++)
                        datagridModule.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Retrieving data from Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }
        
    }
}
