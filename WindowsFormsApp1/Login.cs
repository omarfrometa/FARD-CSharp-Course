using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DoLogin();
            }
        }

        private void DoLogin()
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "fard")
            {
                Main mainForm = new Main();
                mainForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrectos.");
            }
        }

        private bool ValidateForm()
        {
            txtUsername.BackColor = Color.White;
            txtPassword.BackColor = Color.White;

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("El Campo Usuario es requerido.");
                txtUsername.BackColor = Color.LightPink;
                return false;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("El Campo Contraseña es requerido.");
                txtPassword.BackColor = Color.LightPink;
                return false;
            }

            return true;
        }
    }
}
