using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MedicSpace
{
    internal class Medicamento
    {
        private string codigo;
        private string nombre;
        private int cantidad;
        private double precioUnitario;
        private double montoInvertido;

        public Medicamento(string cod, string nom, int cant, double precU, double montI)
        {
            codigo = cod;
            nombre = nom;
            cantidad = cant;
            precioUnitario = precU;
            montoInvertido = montI;
        }

        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public double precioUnit
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }
        public double MontoInvertido
        {
            get { return montoInvertido; }
            set { montoInvertido = value; }
        }
    }

}
