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
    public class ManejadorUsuarios : IManejador
    {
        AccesoDatosUsuarios au =new AccesoDatosUsuarios();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
         
        }

        public void Guardar(dynamic Entidad)
        {
            au.Guardar(Entidad);
            g.Mensaje("Usuario guardado", "!ATENCION", MessageBoxIcon.Information);
        }

        public void Modificar(dynamic Entidad)
        {
            au.Modificar(Entidad);
            g.Mensaje("Usuario modificado", "!ATENCION", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource =
                au.Mostrar(filtro).Tables["usuarios"];
        }
    }
}
