using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    internal class LogicaArticulos:ILogicaArticulo
    {
        //Singleton

        private static LogicaArticulos _instancia = null;

        private LogicaArticulos() { }

        public static LogicaArticulos GetInstance()
        {
            if (_instancia == null)
                _instancia = new LogicaArticulos();

            return _instancia;

        }

        public void AgregarArticulo(Articulo A)
        {
            IPersistenciaArticulo FArticulo = FabricaPersistencia.getPersistenciaArticulos();
            FArticulo.AgregarArticulo(A);
        }

        public Articulo BuscarArticulo(int pCodigo)
        {
            IPersistenciaArticulo FArticulo = FabricaPersistencia.getPersistenciaArticulos();
            return (FArticulo.BuscarArticulo(pCodigo));
        }

        public void EliminarArticulo(Articulo A)
        {
            IPersistenciaArticulo FArticulo = FabricaPersistencia.getPersistenciaArticulos();
            FArticulo.EliminarArticulo(A);
        }

        public List<Articulo> ListarArticulo()
        {
            IPersistenciaArticulo FArticulo = FabricaPersistencia.getPersistenciaArticulos();
            return (FArticulo.ListarArticulo());
        }

        public void ModificarArticulo(Articulo A)
        {
            IPersistenciaArticulo FArticulo = FabricaPersistencia.getPersistenciaArticulos();
            FArticulo.ModificarArticulo(A);
        }
    }
}
