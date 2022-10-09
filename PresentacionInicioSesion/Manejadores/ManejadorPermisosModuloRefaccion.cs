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
    public class ManejadorPermisosModuloRefaccion : IManejador
    {
        AccesoDatosPermisosModuloRefaccion apmr = new AccesoDatosPermisosModuloRefaccion();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            apmr.Guardar(Entidad);
            g.Mensaje("Datos Guardados","!ATENCION",MessageBoxIcon.Information);
        }

        public void Modificar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = apmr.Mostrar(filtro).Tables["Usuarios"];
            
        }
        public void ExtraerUsuario(ComboBox caja)
        {
            caja.DataSource = apmr.Mostrar("").Tables["usuarios"];
            caja.DisplayMember = "Nombre";
            caja.ValueMember = "idusuario";
        }
    }
}
