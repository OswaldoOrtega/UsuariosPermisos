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
    public partial class FrmModuloTallerAdd : Form
    {
        ManejadorModuloTaller mmt;
        public FrmModuloTallerAdd()
        {
            InitializeComponent();
            mmt = new ManejadorModuloTaller();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            mmt.Guardar(new Modulotaller(long.Parse(txtCodigo.Text.ToString()),
                txtNombre.Text,txtMedida.Text,txtMarca.Text,txtDescripcion.Text));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
