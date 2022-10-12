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
    public class AccesoDatosLogeo : IEntidades
    {
        Base b = new Base("localhost", "root", "", "Permisosusuarios", 3306);

        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("call deleteLogeo({0})", Entidad.Idl));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("call insertarLogeo({0},'{1}',{2})", 
                Entidad.FKidusuario, Entidad.Contraseña,Entidad.Idl));
        }

        public void Modificar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call showLogeo('%{0}%')", filtro),"Logeo");
        }
    }
}
