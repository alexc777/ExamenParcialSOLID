using ExamenParcialSOLID.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcialSOLID.Interfaces
{

    interface ICalcularIVA
    {
        double calcularIVA(Cliente cliente);
    }

    interface ICalcularISR
    {
        double calcularISR(Cliente cliente);
    }

    interface ICalcularAhorro
    {
        double calcularAhorro(Cliente cliente);
    }

    interface IDescuentosCliente: ICalcularIVA, ICalcularISR, ICalcularAhorro
    {
        
    }




}
