using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Articulo
    {
        //atributos
        private int _codigo;
        private string _nombre;
        private decimal _precio;
        
        //propiedades
        public int Codigo
        {
            get { return _codigo; }
            set {
                if (value > 0)
                    _codigo = value;
                else
                    throw new Exception("Error en el codigo");
            }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public decimal Precio
        {
            get { return _precio; }
            set {
                if (value > 0)
                    _precio = value;
                else
                    throw new Exception("Precio invalido");
            }
        }
        //Contructor
        public Articulo(int pCodigo, string pNombre, decimal pPrecio)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            Precio = pPrecio;
        }
  
    }
}
