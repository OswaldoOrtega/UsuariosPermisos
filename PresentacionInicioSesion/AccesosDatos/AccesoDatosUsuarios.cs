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
    public class AccesoDatosUsuarios : IEntidades
    {
        Base b = new Base("localhost","root","","Permisosusuarios",3306);
        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("call deleteusuario({0})",Entidad.Idusuario));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("call insertarusuario('{0}','{1}','{2}','{3}','{4}',{5})",
                Entidad.Nombre,Entidad.Apellidop,Entidad.Apellidom,Entidad.Fechanacimiento,Entidad.Rfc,
                Entidad.Idusuario));
        }

        public void Modificar(dynamic Entidad)
        {
            b.comando(string.Format("call modificarusuario('{0}','{1}','{2}','{3}','{4}',{5})",
               Entidad.Nombre, Entidad.Apellidop, Entidad.Apellidom, Entidad.Fechanacimiento, Entidad.Rfc,
               Entidad.Idusuario));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call showusuario('%{0}%')", filtro), "usuarios");
        }
    }
}
