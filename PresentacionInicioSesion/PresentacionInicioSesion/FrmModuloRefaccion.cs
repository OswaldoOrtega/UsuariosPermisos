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
    public partial class FrmModuloRefaccion : Form
    {
        ManejadorModuloRefaccion mmr = new ManejadorModuloRefaccion();
        public static ModuloRefaccion mr = new ModuloRefaccion(0,"","","");
        public static PermisosModuloRefaccion p = new PermisosModuloRefaccion(0,0,"","","","");
        int fila = 0, col = 0;
        public FrmModuloRefaccion()
        {
            InitializeComponent();
            
        }
        void controlarbotones(bool añadir, bool Eliminar, bool Modificar)
        {
            btnAñadir.Enabled = añadir;
            btnEliminar.Enabled = Eliminar;
            btnModificar.Enabled = Modificar;
        }
        public void Permisos()
        {
            if (p.Escritura == "Admitir")
            {
                ControlarBotones(true);
            }
            else if (p.Escritura == "Denegar")
            {
                ControlarBotones(false);
            }
            if (p.Eliminacion == "Admitir")
            {
                ControlarBotones2(true);
            }
            else if (p.Eliminacion == "Denegar")
            {
                ControlarBotones2(false);
            }
            if (p.Actualizacion == "Admitir")
            {
                ControlarBotones3(true);
            }
            else if (p.Actualizacion == "Denegar")
            {
                ControlarBotones3(false);
            }
        }
        public void ControlarBotones(bool nuevo)
        {
            btnAñadir.Enabled = nuevo;
        }
        public void ControlarBotones2(bool eliminar)
        {
            btnEliminar.Enabled = eliminar;
        }
        public void ControlarBotones3(bool modificar)
        {
            btnModificar.Enabled = modificar;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            FrmModuloRefaccionAdd a = new FrmModuloRefaccionAdd();
            a.ShowDialog();
        }
        void actualizar()
        {
            mmr.Mostrar(dtgRefacciones,txtBuscar.Text);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mmr.Borrar(mr);
            actualizar();
        }

        private void dtgRefacciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mr.Codigobarras = long.Parse(dtgRefacciones.Rows[fila].Cells[0].Value.ToString());
            mr.Nombre = dtgRefacciones.Rows[fila].Cells[1].Value.ToString();
            mr.Descripcion = dtgRefacciones.Rows[fila].Cells[2].Value.ToString();
            mr.Marca=dtgRefacciones.Rows[fila].Cells[3].Value.ToString();
            
        }

        private void dtgRefacciones_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void FrmModuloRefaccion_Load(object sender, EventArgs e)
        {
            Permisos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmModuloRefaccionModificar ad = new FrmModuloRefaccionModificar();
            ad.ShowDialog();
            actualizar();
        }
    }
}
