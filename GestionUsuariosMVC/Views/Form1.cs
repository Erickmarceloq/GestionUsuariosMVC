using System;
using System.Linq;
using System.Windows.Forms;
using GestionUsuariosMVC.Controllers;
using GestionUsuariosMVC.Models;

namespace GestionUsuariosMVC.Views
{
    public partial class Form1 : Form
    {
        private readonly UsuarioController _usuarioController = new UsuarioController();
        private readonly RolController _rolController = new RolController();
        private int? _idUsuarioSeleccionado = null;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

            // Enlace manual de seguridad para asegurar que los clics respondan
            this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
            this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
            this.dgvUsuarios.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarRoles();
            ListarUsuarios();
        }

        private void CargarRoles()
        {
            try
            {
                var roles = _rolController.ObtenerTodos();
                cmbRoles.DataSource = roles;
                cmbRoles.DisplayMember = "NombreRol";
                cmbRoles.ValueMember = "IdRol";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource = null;
                var usuarios = _usuarioController.ObtenerTodos();

                dgvUsuarios.DataSource = usuarios.Select(u => new
                {
                    IdUsuario = u.IdUsuario,
                    Nombre = u.Nombre,
                    Correo = u.Correo,
                    Rol = u.Rol != null ? u.Rol.NombreRol : "Sin Rol"
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRoles.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un rol válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_idUsuarioSeleccionado == null)
                {
                    Usuario nuevo = new Usuario
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Correo = txtCorreo.Text.Trim(),
                        IdRol = (int)cmbRoles.SelectedValue
                    };

                    _usuarioController.Crear(nuevo);
                    MessageBox.Show("¡Usuario creado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Usuario existente = new Usuario
                    {
                        IdUsuario = _idUsuarioSeleccionado.Value,
                        Nombre = txtNombre.Text.Trim(),
                        Correo = txtCorreo.Text.Trim(),
                        IdRol = (int)cmbRoles.SelectedValue
                    };

                    _usuarioController.Actualizar(existente);
                    MessageBox.Show("¡Usuario actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpiarCampos();
                ListarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la solicitud: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    _idUsuarioSeleccionado = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["IdUsuario"].Value);
                    txtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    txtCorreo.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Correo"].Value.ToString();

                    string nombreRol = dgvUsuarios.Rows[e.RowIndex].Cells["Rol"].Value.ToString();
                    cmbRoles.SelectedIndex = cmbRoles.FindStringExact(nombreRol);

                    btnGuardar.Text = "Actualizar";
                }
                catch
                {
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            if (cmbRoles.Items.Count > 0) cmbRoles.SelectedIndex = 0;
            _idUsuarioSeleccionado = null;
            btnGuardar.Text = "Guardar";
            txtNombre.Focus();
        }
    }
}