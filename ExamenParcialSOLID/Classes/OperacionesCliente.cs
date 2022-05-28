using ExamenParcialSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcialSOLID.Classes
{
    public class OperacionesCliente : IOperacionesCliente, IDescuentosCliente
    {
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
            throw new NotImplementedException();
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
