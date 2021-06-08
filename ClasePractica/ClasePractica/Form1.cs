using ClasePractica.Poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasePractica
{
    public partial class Form1 : Form
    {
        public int id_register = 0;
        public Empleado add_empleado = new Empleado();
        public Form1()
        {
            InitializeComponent();
        }

        private void loadFrmEmpleado(object sender, EventArgs e)
        {
            cmbProfesion.Items.AddRange(Enum.GetValues(typeof(EnumProfesion)).Cast<object>().ToArray());
            cmbProfesion.SelectedIndex = 0;

            cmbCargo.Items.AddRange(Enum.GetValues(typeof(EnumCargo)).Cast<object>().ToArray());
            cmbCargo.SelectedIndex = 0;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            int id = id_register + 1;
            string nombre = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string cedula = txtCedula.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            EnumProfesion profesion = (EnumProfesion)Enum.GetValues(typeof(EnumProfesion)).GetValue(cmbProfesion.SelectedIndex);
            EnumCargo cargo = (EnumCargo)Enum.GetValues(typeof(EnumCargo)).GetValue(cmbCargo.SelectedIndex);
            decimal salario = Convert.ToDecimal(txtSalario.Text);

        }
    }
}
