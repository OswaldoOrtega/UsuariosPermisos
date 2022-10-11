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
        AccesoDatosUsuarios adu = new AccesoDatosUsuarios();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                 string.Format("¿Está seguro de borrar {0}",
                 Entidad.Idp),
                 "!Atención", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                apmr.Borrar(Entidad);
        }

        public void Guardar(dynamic Entidad)
        {
            apmr.Guardar(Entidad);
            g.Mensaje("Datos Guardados","!ATENCION",MessageBoxIcon.Information);
        }

        public void Modificar(dynamic Entidad)
        {
            apmr.Modificar(Entidad);
            g.Mensaje("Datos Modificados", "!ATENCION", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = apmr.Mostrar(filtro).Tables["permisosrefaccion"];
            
        }
        public void ExtraerUsuario(ComboBox caja)
        {
            caja.DataSource = adu.Mostrar("").Tables["usuarios"];
            caja.DisplayMember = "nombre";
            caja.ValueMember = "idusuario";
        }
    }
}
