using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Logeo
    {
        public Logeo(int idl, int fKidusuario, string contraseña)
        {
            Idl = idl;
            FKidusuario = fKidusuario;
            Contraseña = contraseña;
        }

        public int Idl { get; set; }
        public int FKidusuario { get; set; }
        public string Contraseña { get; set; }
    }
}
