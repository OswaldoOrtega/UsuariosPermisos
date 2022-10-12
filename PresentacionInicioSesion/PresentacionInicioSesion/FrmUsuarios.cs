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
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios mu;
        public static Usuarios u = new Usuarios(0,"","","","","");

        public static List<Usuarios> listausuario = new List<Usuarios>();

        int fila = 0, col = 0;
        public FrmUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmUsuarios a = new FrmUsuarios();
            a.ShowDialog();
            actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mu.Borrar(u);
            actualizar();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            FrmUsuariosAdd a = new FrmUsuariosAdd();
            a.ShowDialog();

        }

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            u.Idusuario = int.Parse(dtgUsuarios.Rows[fila].Cells[0].Value.ToString());
            u.Apellidop = dtgUsuarios.Rows[fila].Cells[1].Value.ToString();
            u.Apellidom= dtgUsuarios.Rows[fila].Cells[2].Value.ToString();
            u.Fechanacimiento= dtgUsuarios.Rows[fila].Cells[3].Value.ToString();
            u.Rfc= dtgUsuarios.Rows[fila].Cells[4].Value.ToString();
        }

        private void dtgUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        void actualizar()
        {
            mu.Mostrar(dtgUsuarios,txtUsuario.Text);
        }
    }
}
