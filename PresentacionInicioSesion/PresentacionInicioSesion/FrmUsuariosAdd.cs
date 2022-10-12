using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;
namespace PresentacionInicioSesion
{
    public partial class FrmUsuariosAdd : Form
    {
        ManejadorUsuarios mu;
        public FrmUsuariosAdd()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            if(FrmUsuarios.u.Idusuario > 0)
            {
                txtNombre.Text = FrmUsuarios.u.Nombre;
                txtApellidop.Text = FrmUsuarios.u.Apellidop;
                txtApellidom.Text = FrmUsuarios.u.Apellidom;
                txtNacimiento.Text = FrmUsuarios.u.Fechanacimiento;
                txtRfc.Text = FrmUsuarios.u.Rfc;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mu.Guardar(new Usuarios(FrmUsuarios.u.Idusuario,txtNombre.Text,txtApellidop.Text,txtApellidom.Text,
                txtNacimiento.Text,txtRfc.Text));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
