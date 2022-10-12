using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesosDatos;
using Crud;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorLogeo : IManejador
    {
        AccesoDatosLogeo al = new AccesoDatosLogeo();
        AccesoDatosUsuarios adu = new AccesoDatosUsuarios();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("¿Está seguro de borrar {0}",
                Entidad.Idl),
                "!Atención", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                al.Borrar(Entidad);
        }

        public void Guardar(dynamic Entidad)
        {
            al.Guardar(Entidad);
            g.Mensaje("Se guardaron los datos correctamente","!ATENCION",MessageBoxIcon.Information);
        }

        public void Modificar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = al.Mostrar(filtro).Tables["Logeo"];
            tabla.Columns[0].Visible = false;
        }

        public void ExtraerUsuario(ComboBox caja)
        {
            caja.DataSource = adu.Mostrar("").Tables["usuarios"];
            caja.DisplayMember = "nombre";
            caja.ValueMember = "idusuario";
        }
    }
}
