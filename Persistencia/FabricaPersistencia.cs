﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;


namespace Persistencia
{
    public class FabricaPersistencia
    {
        public static IPersistenciaArticulo getPersistenciaArticulos()
        {

            return (PersistenciaArticulos.GetInstancia());


        }

    }
}
