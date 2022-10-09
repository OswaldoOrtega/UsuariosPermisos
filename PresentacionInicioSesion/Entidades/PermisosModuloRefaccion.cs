using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PermisosModuloRefaccion
    {
        public PermisosModuloRefaccion(string idp, int fKidusuario, bool lectura, bool escritura, bool eliminacion, bool actualizacion)
        {
            Idp = idp;
            FKidusuario = fKidusuario;
            Lectura = lectura;
            Escritura = escritura;
            Eliminacion = eliminacion;
            Actualizacion = actualizacion;
        }

        public string Idp { get; set; }
        public int FKidusuario { get; set; }
        public bool Lectura { get; set; }
        public bool Escritura { get; set; }
        public bool Eliminacion { get; set; }
        public bool Actualizacion { get; set; }
    }
}
