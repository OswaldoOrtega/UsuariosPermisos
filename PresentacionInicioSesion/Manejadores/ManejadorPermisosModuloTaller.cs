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
    public class ManejadorPermisosModuloTaller : IManejador
    {
        AccesoDatosPermisosModuloTaller apmt = new AccesoDatosPermisosModuloTaller();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            apmt.Guardar(Entidad);
            g.Mensaje("Datos Guardados", "!ATENCION", MessageBoxIcon.Information);
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
