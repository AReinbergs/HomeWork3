using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HW_WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random code = new Random();
            lblRandomCode.Text = code.Next(100, 999).ToString();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            var RGX = Regex.IsMatch(txtName.Text, "^(?<firstchar>(?=[A-Za-z]))((?<alphachars>[A-Za-z])|(?<specialchars>[A-Za-z]['-](?=[A-Za-z]))|(?<spaces> (?=[A-Za-z])))*$");

            if (!RGX)
            {
                txtName.Focus();
                ErrorName.Visible = true;
                txtName.Clear();
                lblFullName.Visible = false;
            }

            else
            {
                ErrorName.Visible = false;
                lblFullName.Text = txtName.Text + " " + txtSurname.Text;
                lblFullName.Visible = true;
            }
            //txtSurname.Focus();

        }

        private void txtSurname_Leave(object sender, EventArgs e)
        {
            var RGX = Regex.IsMatch(txtSurname.Text, "^(?<firstchar>(?=[A-Za-z]))((?<alphachars>[A-Za-z])|(?<specialchars>[A-Za-z]['-](?=[A-Za-z]))|(?<spaces> (?=[A-Za-z])))*$");

            if (!RGX)
            {
                txtSurname.Focus();
                ErrorSurname.Visible = true;
                txtSurname.Clear();
                lblFullName.Visible = false;
            }

            else
            {
                ErrorSurname.Visible = false;
                lblFullName.Text = txtName.Text + " " + txtSurname.Text;
                lblFullName.Visible = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            var RGX = Regex.IsMatch(txtPassword.Text, "^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{5,}$");

            if (!RGX)
            {
                txtPassword.Focus();
                ErrorPassword.Visible = true;
            }
            else
            {
                ErrorPassword.Visible = false;
            }           
        }
                
        private void txtRepeatPassword_Enter(object sender, EventArgs e)
        {
            string Password = txtPassword.Text;
            string Repeat = txtRepeatPassword.Text;
            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please fill in the PASSWORD firts");
                txtRepeatPassword.Focus();
            }
            else
            {

            }
            
        }
        private void txtRepeatPassword_Leave(object sender, EventArgs e)
        {
            

            if (txtPassword.Text != txtRepeatPassword.Text)
            {
                txtRepeatPassword.Focus();
                lblRepeat.Visible = true;
            }
            else
            {
                lblRepeat.Visible = false;
            }
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            var date = dateTimePicker1.Text.Remove(6,2);
            
            maskedTextBox1.Text = date;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            try
            { 
                new System.Net.Mail.MailAddress(txtEmail.Text);
                lblEmail.Visible = false;
            }
            catch
            {
                txtEmail.Focus();
                lblEmail.Visible = true;
            }
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (txtCode.Text != lblRandomCode.Text)
            {
                txtCode.Focus();
                lblCodeError.Visible = true;
            }
            else
            {
                lblCodeError.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSurname.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtCode.Text) || string.IsNullOrEmpty(maskedTextBox1.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtRepeatPassword.Text))
            {
            
            
                MessageBox.Show("Please fill all the fealds");
            

            }
            else
            {
            string message = $"Successful registration for:\n\n  Full Name: {lblFullName.Text}\n  Birthday: {dateTimePicker1.Text}\n  SSN: {maskedTextBox1.Text}\n  E-mail: {txtEmail.Text}";
            MessageBox.Show(message);

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
