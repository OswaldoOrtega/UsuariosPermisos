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
    
    public partial class FrmLogeo : Form
    {
        ManejadorLogeo ml;
        public static Logeo l = new Logeo(0,0,"");
        public static string Usuario = "";
        int fila = 0, col = 0;
        public FrmLogeo()
        {
            InitializeComponent();
            ml = new ManejadorLogeo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            l.Idl = -1;
            FrmLogeoAdd a = new FrmLogeoAdd();
            a.ShowDialog();
            actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ml.Borrar(l);
            actualizar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmLogeoAdd a = new FrmLogeoAdd();
            a.ShowDialog();
            txtbuscar.Text = "";
            actualizar();
        }
        void actualizar()
        {
            ml.Mostrar(dtgLogeo,txtbuscar.Text);
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void dtgLogeo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            l.Idl = int.Parse(dtgLogeo.Rows[fila].Cells[0].Value.ToString());
            Usuario = dtgLogeo.Rows[fila].Cells[1].Value.ToString();
            l.Contraseña = dtgLogeo.Rows[fila].Cells[2].Value.ToString();
        }

        private void FrmLogeo_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void dtgLogeo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }
    }
}
