using ClasePractica.Model;
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
        public int id_register = 1;
        public EmpleadoModel eModel = new EmpleadoModel();
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
            int id = id_register;
            string nombre = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string cedula = txtCedula.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            EnumProfesion profesion = (EnumProfesion)Enum.GetValues(typeof(EnumProfesion)).GetValue(cmbProfesion.SelectedIndex);
            EnumCargo cargo = (EnumCargo)Enum.GetValues(typeof(EnumCargo)).GetValue(cmbCargo.SelectedIndex);
            decimal salario = Convert.ToDecimal(txtSalario.Text);


            Empleado add_empleado = new Empleado {
                Id = id,
                Nombres = nombre,
                Apellidos = apellidos,
                Cedula = cedula,
                Telefono = telefono,
                Correo = correo,
                Profesion = profesion,
                Cargo = cargo,
                Salario = salario,
            };
            eModel.AddElements(add_empleado);
            id_register++;
            ActualizarDataGridView();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (tblShow.SelectedRows.Count > 0)
            {
                Actualizar frmActualizar = new Actualizar();
                frmActualizar.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila
            if (tblShow.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indiceSeleccionado = tblShow.SelectedRows[0].Index;

                // Eliminar el registro de la lista de empleados
                eModel.Remove(indiceSeleccionado);

                // Actualizar el DataGridView con todos los empleados
                ActualizarDataGridView();
            }
        }

        private void ActualizarDataGridView()
        {
            // Obtener todos los empleados
            Empleado[] todosLosEmpleados = eModel.GetAll();

            // Asignar los empleados al origen de datos del DataGridView
            tblShow.DataSource = null; // Limpiar los datos existentes
            tblShow.DataSource = todosLosEmpleados; // Asignar la lista de empleados como origen de datos
        }
    }
}

