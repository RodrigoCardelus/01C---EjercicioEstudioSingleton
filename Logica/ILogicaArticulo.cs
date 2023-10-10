﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    public interface ILogicaArticulo
    {
        void AgregarArticulo(Articulo A);

        void EliminarArticulo(Articulo A);

        void ModificarArticulo(Articulo A);

        Articulo BuscarArticulo(int pCodigo);

        List<Articulo> ListarArticulo();



    }
}
