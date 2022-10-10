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
        public static PermisosModuloRefaccion pm = new PermisosModuloRefaccion("",0,true,true,true,true);
        public static int usuario = 0;
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
            pm.Idp = dtgPermisosRefaccion.Rows[fila].Cells[0].Value.ToString();
            usuario = int.Parse(dtgPermisosRefaccion.Rows[fila].Cells[1].Value.ToString());
            pm.Lectura = bool.Parse(dtgPermisosRefaccion.Rows[fila].Cells[2].Value.ToString());
            pm.Escritura = bool.Parse(dtgPermisosRefaccion.Rows[fila].Cells[2].Value.ToString());
            pm.Eliminacion = bool.Parse(dtgPermisosRefaccion.Rows[fila].Cells[2].Value.ToString());
            pm.Actualizacion = bool.Parse(dtgPermisosRefaccion.Rows[fila].Cells[2].Value.ToString());
        }

        private void dtgPermisosRefaccion_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}
