﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
using Entidades;
namespace AccesosDatos
{
    public class AccesoDatosModuloTaller : IEntidades
    {
        Base b = new Base("localhost", "root", "", "Permisosusuarios", 3306);
        public void Borrar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
           b.comando(string.Format("call insertarmodulotaller({0},'{1}','{2}','{3}','{4}')",
               Entidad.Codigoherramientas,Entidad.Nombre,Entidad.Medida,Entidad.Marca,Entidad.Descripcion));
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
