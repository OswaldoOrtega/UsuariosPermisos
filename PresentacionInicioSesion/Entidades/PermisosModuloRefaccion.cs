using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PermisosModuloRefaccion
    {
        public PermisosModuloRefaccion(int fKidusuario, long fKcodigobarras, bool lectura, bool escritura, bool eliminacion, bool actualizacion)
        {
            FKidusuario = fKidusuario;
            FKcodigobarras = fKcodigobarras;
            Lectura = lectura;
            Escritura = escritura;
            Eliminacion = eliminacion;
            Actualizacion = actualizacion;
        }

        public int FKidusuario { get; set; }
        public long FKcodigobarras { get; set; }
        public bool Lectura { get; set; }
        public bool Escritura { get; set; }
        public bool Eliminacion { get; set; }
        public bool Actualizacion { get; set; }
    }
}
