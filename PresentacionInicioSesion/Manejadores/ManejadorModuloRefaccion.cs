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
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            amr.Guardar(Entidad);
            g.Mensaje("Refaccion Guardada","!ATENCION",MessageBoxIcon.Information);
        }

        public void Modificar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
