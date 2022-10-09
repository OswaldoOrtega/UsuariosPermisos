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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            FrmModuloRefaccionAdd ad = new FrmModuloRefaccionAdd();
            ad.ShowDialog();
        }
    }
}
