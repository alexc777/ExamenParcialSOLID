using ExamenParcialSOLID.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcialSOLID.Interfaces
{
    interface ICrearCliente
    {
        void crear(Cliente cliente);
    }

    interface IEditarCliente
    {
        void editar(Cliente cliente);
    }

    interface IEliminarCliente
    {
        void eliminar(Cliente cliente);
    }

    interface IOperacionesCliente: ICrearCliente, IEditarCliente, IEliminarCliente
    {
        
    }


}
