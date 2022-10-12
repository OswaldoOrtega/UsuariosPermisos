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
    public partial class FrmInicioSesion : Form
    {
        ManejadorUsuarios a;
        ManejadorLogeo ml;
       public static List<Usuarios> listausuario = new List<Usuarios>();
       
        public FrmInicioSesion()
        {
            InitializeComponent();
            ml = new ManejadorLogeo();
            a = new ManejadorUsuarios();
            
        }
        
        public void acceso()
        {
            
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            acceso();
        }
    }
}
