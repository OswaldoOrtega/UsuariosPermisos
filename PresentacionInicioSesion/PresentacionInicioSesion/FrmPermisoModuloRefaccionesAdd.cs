﻿using System;
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
    public partial class FrmPermisoModuloRefaccionesAdd : Form
    {
        ManejadorPermisosModuloRefaccion mpmr;
        public FrmPermisoModuloRefaccionesAdd()
        {
            InitializeComponent();
            mpmr = new ManejadorPermisosModuloRefaccion();
            mpmr.ExtraerUsuario(cmbUsuario);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mpmr.Guardar(new PermisosModuloRefaccion(FrmPermisoModuloRefacciones.pmr.Idp,
                int.Parse(cmbUsuario.SelectedValue.ToString()),
                bool.Parse(txtL.Text.ToString()),bool.Parse(txtE.Text.ToString()),
                bool.Parse(txtEliminacion.Text.ToString()),bool.Parse(txtA.Text.ToString())));
        }
    }
}
