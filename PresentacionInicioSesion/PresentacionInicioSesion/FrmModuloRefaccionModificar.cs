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
    public partial class FrmModuloRefaccionModificar : Form
    {
        ManejadorModuloRefaccion mr;
        public FrmModuloRefaccionModificar()
        {
            InitializeComponent();
            mr = new ManejadorModuloRefaccion();
            if (FrmModuloRefaccion.mr.Codigobarras > 0)
            {
                txtCodigo.Text = FrmModuloRefaccion.mr.Codigobarras.ToString();
                txtNombre.Text = FrmModuloRefaccion.mr.Nombre;
                txtDescripcion.Text = FrmModuloRefaccion.mr.Descripcion;
                txtMarca.Text = FrmModuloRefaccion.mr.Marca;
            }
        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnModificaion_Click_1(object sender, EventArgs e)
        {
            mr.Modificar(new ModuloRefaccion(long.Parse(txtCodigo.Text.ToString()),
                txtNombre.Text, txtDescripcion.Text, txtMarca.Text));
            Close();
        }
    }
}
