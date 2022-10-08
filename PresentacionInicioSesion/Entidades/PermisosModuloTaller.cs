using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PermisosModuloTaller
    {
        public PermisosModuloTaller(int fKidusuario, long fKcodigoherramientas, bool lectura, bool escritura, bool eliminacion, bool actualizacion)
        {
            FKidusuario = fKidusuario;
            FKcodigoherramientas = fKcodigoherramientas;
            Lectura = lectura;
            Escritura = escritura;
            Eliminacion = eliminacion;
            Actualizacion = actualizacion;
        }

        public int FKidusuario { get; set; }
        public long FKcodigoherramientas { get; set; }
        public bool Lectura { get; set; }
        public bool Escritura { get; set; }
        public bool Eliminacion { get; set; }
        public bool Actualizacion { get; set; }
    }
}
