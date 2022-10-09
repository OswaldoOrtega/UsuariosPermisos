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
    public partial class FrmModuloRefaccionAdd : Form
    {
        ManejadorModuloRefaccion mr;
        public FrmModuloRefaccionAdd()
        {
            InitializeComponent();
            mr = new ManejadorModuloRefaccion();
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mr.Guardar(new ModuloRefaccion(long.Parse(txtCodigo.Text.ToString()),
                txtNombre.Text,txtDescripcion.Text,txtMarca.Text));
            Close();
        }

      
    }
}
