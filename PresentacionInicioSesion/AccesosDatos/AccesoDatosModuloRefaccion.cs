using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using ConectarBd;
namespace AccesosDatos
{
    public class AccesoDatosModuloRefaccion : IEntidades
    {
        Base b = new Base("localhost","root","", "Permisosusuarios",3306);
        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("call deletemodulorefaccion({0})",Entidad.Codigobarras));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("call insertarmodulorefaccion({0},'{1}','{2}','{3}')",
                Entidad.Codigobarras,Entidad.Nombre,Entidad.Descripcion,Entidad.Marca));
        }

        public void Modificar(dynamic Entidad)
        {
            b.comando(string.Format("call modificarmodulorefaccion({0},'{1}','{2}','{3}')",
               Entidad.Codigobarras ,Entidad.Nombre, Entidad.Descripcion, Entidad.Marca));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call showmodulorefaccion('%{0}%')",filtro), "ModuloRefaccion");
        }
    }
}
