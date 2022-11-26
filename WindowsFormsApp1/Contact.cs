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
    public partial class Contact : Form
    {
        FARD_COURSE_DBEntities db = new FARD_COURSE_DBEntities();

        public Contact()
        {
            InitializeComponent();

            GetDefaults();
        }

        private void GetDefaults()
        {
            GetContacts();
            GetLugarNacimiento();
        }

        private void GetLugarNacimiento()
        {
            //Cargando todas los lugares de nacimiento desde la base de datos
            var lugaresNacimiento = db.LugarDeNacimiento.Where(x=> x.Activo == true).ToList();

            //Asignando los lugares a la lista
            cbLugarNacimiento.DataSource = lugaresNacimiento;
            cbLugarNacimiento.DisplayMember = "Nombre";
            cbLugarNacimiento.ValueMember = "Id";
        }

        private void GetContacts()
        {
            var contacts = db.Contacto.ToList();

            //Filtro
            if (cbFiltrarPor.SelectedIndex == 0) //Nombre
            {
                contacts = contacts.Where(c => c.Nombre.Contains(txtCriterio.Text)).ToList();
            }
            else if (cbFiltrarPor.SelectedIndex == 1) //Apellidos
            {
                contacts = contacts.Where(c => c.Apellidos.ToLower().Contains(txtCriterio.Text.ToLower())).ToList();
            }
            else if (cbFiltrarPor.SelectedIndex == 2) //Sexo
            {
                var criterio = txtCriterio.Text.ToLower().Equals("hombre") ? "H" : txtCriterio.Text.ToLower().Equals("mujer") ? "F" : "";
                contacts = contacts.Where(c => c.Sexo == criterio).ToList();
            }
            else if (cbFiltrarPor.SelectedIndex == 3) //Correo Electronico
            {
                contacts = contacts.Where(c => c.CorreoElectronico.Contains(txtCriterio.Text)).ToList();
            }
            else if (cbFiltrarPor.SelectedIndex == 4) //Telefono
            {
                contacts = contacts.Where(c => c.Telefono.Contains(txtCriterio.Text)).ToList();
            }

            dgvContactos.DataSource = null;
            dgvContactos.DataSource = contacts;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ContactSave();
        }

        private void ContactSave()
        {
            var c = new Contacto();
            c.Nombre = txtNombre.Text;
            c.Apellidos = txtApellido.Text;
            c.FechaNacimiento = dtpFechaNacimiento.Value;
            c.IdLugarNacimiento = Convert.ToInt32(cbLugarNacimiento.SelectedValue);
            c.Sexo = rbHombre.Checked ? "M" : "F";
            c.Direccion = txtDireccion.Text;
            c.CorreoElectronico = txtCorreoElectronico.Text;
            c.Telefono = txtTelefono.Text;
            c.CreadoPor = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            c.FechaCreacion = DateTime.Now;

            db.Contacto.Add(c);
            var result = db.SaveChanges() > 0;

            if (result)
            {
                MessageBox.Show("Contacto Guardado");

                GetContacts();
                EmptyForm();
            }
        }

        private void EmptyForm()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCorreoElectronico.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            GetContacts();
        }
    }
}
