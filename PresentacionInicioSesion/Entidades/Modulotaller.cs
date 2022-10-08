using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Modulotaller
    {
        public Modulotaller(long codigoherramientas, string nombre, string medida, string marca, string descripcion)
        {
            Codigoherramientas = codigoherramientas;
            Nombre = nombre;
            Medida = medida;
            Marca = marca;
            Descripcion = descripcion;
        }

        public long Codigoherramientas { get; set; }
        public string Nombre { get; set; }
        public string Medida { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
    }
}
