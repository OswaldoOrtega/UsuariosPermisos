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
    public partial class FrmLogeoAdd : Form
    {
        ManejadorLogeo ml;
        public FrmLogeoAdd()
        {
            InitializeComponent();
            ml = new ManejadorLogeo();
            ml.ExtraerUsuario(cmbUsuario);
            if(FrmLogeo.l.Idl>0)
            {
                cmbUsuario.Text = FrmLogeo.Usuario;
                txtContraseña.Text = FrmLogeo.l.Contraseña.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ml.Guardar(new Logeo(FrmLogeo.l.Idl,
                int.Parse(cmbUsuario.SelectedValue.ToString()),txtContraseña.Text));
            Close();
        }
    }
}