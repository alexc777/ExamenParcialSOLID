using ExamenParcialSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcialSOLID.Classes
{
    public class OperacionesCliente : IOperacionesCliente, IDescuentosCliente, ICalcularRubro
    {
        public double determinarPorcentajeRubro(Rubros rubro)
        {
            double porcentaje = 0;

            if (rubro.idRubro == 1)
            {
                //gastos
                porcentaje = 0.05;
            }
            else if (rubro.idRubro == 2)
            {
                // publicidad
                porcentaje = 0.1;
            }
            else if (rubro.idRubro == 3)
            {
                // caja chica
                porcentaje = 0.85;
            }

            return porcentaje;
        }

        public double calcularAhorro(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public double calcularISR(Cliente cliente)
        {
            double ISR;

            if (cliente.salario <= 30000.00)
            {
                ISR = cliente.salario * 0.05;
            }
            else
            {
                ISR = cliente.salario * 0.07;
            }

            return ISR;
        }

        public double calcularIVA(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void crear(Cliente cliente)
        {
            //simulación de la creación de un cliente.
            Console.WriteLine("***********************");
            Console.WriteLine("\n");
            Console.WriteLine("Cliente Creado");
            Console.WriteLine("\n");
            Console.WriteLine("***********************");
            Console.WriteLine("\n");
        }

        public void editar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void eliminar(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
