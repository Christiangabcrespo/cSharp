﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    interface Entregable
    {
        void entregar();
        void devolver();
        bool isEntregado();
        void compareTo(Object e);
    }
}
