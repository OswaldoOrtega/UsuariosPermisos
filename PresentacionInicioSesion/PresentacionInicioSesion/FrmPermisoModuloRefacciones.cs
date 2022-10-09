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
    public partial class FrmPermisoModuloRefacciones : Form
    {
        ManejadorPermisosModuloRefaccion mpmr;
        public static PermisosModuloRefaccion pmr = new PermisosModuloRefaccion("",0,false,false,false,false);
        public static int usuario = 0;
        public FrmPermisoModuloRefacciones()
        {
            InitializeComponent();
            mpmr = new ManejadorPermisosModuloRefaccion();
        }
        void actualizar()
        {
            mpmr.Mostrar(dtgPermisosRefaccion,txtBuscar.Text);
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            FrmPermisoModuloRefaccionesAdd a = new FrmPermisoModuloRefaccionesAdd();
            a.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}
