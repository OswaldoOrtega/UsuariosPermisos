using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PermisosModuloRefaccion
    {
        public PermisosModuloRefaccion(int idp, int fKidusuario, string lectura, string escritura, string eliminacion, string actualizacion)
        {
            Idp = idp;
            FKidusuario = fKidusuario;
            Lectura = lectura;
            Escritura = escritura;
            Eliminacion = eliminacion;
            Actualizacion = actualizacion;
        }

        public int Idp { get; set; }
        public int FKidusuario { get; set; }
        public string Lectura { get; set; }
        public string Escritura { get; set; }
        public string Eliminacion { get; set; }
        public string Actualizacion { get; set; }
    }
}
