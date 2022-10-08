using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ModuloRefaccion
    {
        public ModuloRefaccion(long codigobarras, string nombre, string descripcion, string marca)
        {
            Codigobarras = codigobarras;
            Nombre = nombre;
            Descripcion = descripcion;
            Marca = marca;
        }

        public long Codigobarras { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
    }
}
