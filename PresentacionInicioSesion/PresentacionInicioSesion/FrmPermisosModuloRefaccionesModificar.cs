using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;
namespace PresentacionInicioSesion
{
    public partial class FrmPermisosModuloRefaccionesModificar : Form
    {
        ManejadorPermisosModuloRefaccion m;
        public FrmPermisosModuloRefaccionesModificar()
        {
            InitializeComponent();
            m = new ManejadorPermisosModuloRefaccion();
            m.ExtraerUsuario(cmbUsuario);
            if(!FrmPermisoModuloRefacciones.pm.Idp.Equals (""))
            {
                txtID.Text = FrmPermisoModuloRefacciones.pm.Idp.ToString();
                cmbUsuario.Text = FrmPermisoModuloRefacciones.usuario;
                cmbLectura.Text = FrmPermisoModuloRefacciones.pm.Lectura.ToString();
                cmbEscritura.Text = FrmPermisoModuloRefacciones.pm.Escritura.ToString();
                cmbEliminacion.Text = FrmPermisoModuloRefacciones.pm.Eliminacion.ToString();
                cmbActualizacion.Text = FrmPermisoModuloRefacciones.pm.Actualizacion.ToString();    
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarModificar_Click(object sender, EventArgs e)
        {
            m.Modificar(new PermisosModuloRefaccion(txtID.Text,int.Parse(cmbUsuario.SelectedValue.ToString()),
                cmbLectura.Text, cmbEscritura.Text, 
                cmbEliminacion.Text, cmbActualizacion.Text));
            Close();  
        }
    }
}
