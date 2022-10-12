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
        public static PermisosModuloRefaccion pm = new PermisosModuloRefaccion(0,0,"","","","");
        public static string usuario = "";
        int fila = 0, col = 0;
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

        private void dtgPermisosRefaccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                pm.Idp = int.Parse(dtgPermisosRefaccion.Rows[fila].Cells[0].Value.ToString());
                usuario = dtgPermisosRefaccion.Rows[fila].Cells[1].Value.ToString();
                pm.Lectura = dtgPermisosRefaccion.Rows[fila].Cells[2].Value.ToString();
                 pm.Escritura = dtgPermisosRefaccion.Rows[fila].Cells[3].Value.ToString();
                 pm.Eliminacion = dtgPermisosRefaccion.Rows[fila].Cells[4].Value.ToString();
                 pm.Actualizacion = dtgPermisosRefaccion.Rows[fila].Cells[5].Value.ToString();
        }

        private void dtgPermisosRefaccion_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void FrmPermisoModuloRefacciones_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmPermisosModuloRefaccionesModificar a = new FrmPermisosModuloRefaccionesModificar();
            a.ShowDialog();
            actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mpmr.Borrar(pm);
            actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}
