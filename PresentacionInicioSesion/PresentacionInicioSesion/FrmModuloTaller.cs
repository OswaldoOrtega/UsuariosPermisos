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
    public partial class FrmModuloTaller : Form
    {
        ManejadorModuloTaller mmt;
        public static Modulotaller mt = new Modulotaller(0,"","","","");
        public FrmModuloTaller()
        {
            InitializeComponent();
            mmt = new ManejadorModuloTaller();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            FrmModuloTallerAdd mta = new FrmModuloTallerAdd();
            mta.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
