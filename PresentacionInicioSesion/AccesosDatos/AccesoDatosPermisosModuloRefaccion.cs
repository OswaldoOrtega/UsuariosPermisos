using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
using Entidades;
namespace AccesosDatos
{
    public class AccesoDatosPermisosModuloRefaccion : IEntidades
    {
        Base b = new Base("localhost", "root", "", "Permisosusuarios", 3306);
        public void Borrar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("call insertarpermisosrefaccion({0},{1},{2},{3},{4},{5})",
                Entidad.FKidusuario,Entidad.FKcodigobarras,Entidad.Lectura,
                Entidad.Escritura,Entidad.Eliminacion,Entidad.Actualizacion));
        }

        public void Modificar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public DataSet Mostrar(string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
