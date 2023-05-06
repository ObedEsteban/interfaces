using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corto.MisInterfaces
{
    internal interface Ipersona
    {
        string Nombre { get; }
        int Edad { get; }
        void DecirMiNombre();
        void cumpirAños();
    }

}

