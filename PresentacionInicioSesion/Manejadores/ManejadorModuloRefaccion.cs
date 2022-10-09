using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesosDatos;
using Entidades;
using Crud;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorModuloRefaccion : IManejador
    {
        AccesoDatosModuloRefaccion amr = new AccesoDatosModuloRefaccion();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("¿Estás seguro de borrar {0}", Entidad.Nombre),
                "!ATENCION",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                amr.Borrar(Entidad);
        }

        public void Guardar(dynamic Entidad)
        {
            amr.Guardar(Entidad);
            g.Mensaje("Refaccion Guardada","!ATENCION",MessageBoxIcon.Information);
        }

        public void Modificar(dynamic Entidad)
        {
            amr.Modificar(Entidad);
            g.Mensaje("Refaccion Modificada", "!ATENCION", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource =amr.Mostrar(filtro).Tables["ModuloRefaccion"];
        }
    }
}
