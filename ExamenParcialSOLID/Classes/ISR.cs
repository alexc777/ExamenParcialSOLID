using ExamenParcialSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcialSOLID.Classes
{
    public class ISR : ICalcularISR
    {
        public double calcularISR(Cliente cliente)
        {
            double ISR;

            if (cliente.salario <= 30000.00)
            {
                ISR = cliente.salario * 0.05;
            } else
            {
                ISR = cliente.salario * 0.07;
            }

            return ISR;
        }
    }
}
