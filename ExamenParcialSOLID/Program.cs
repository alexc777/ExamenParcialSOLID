using ExamenParcialSOLID.Classes;
using System;

namespace ExamenParcialSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************");
            Console.WriteLine("Examen Parcial");
            Console.WriteLine("***********************");
            Console.WriteLine("\n");

            var cliente = new Cliente();
            cliente.idCliente = 1;
            cliente.nombre = "Osman";
            cliente.apellido = "Cruz";
            cliente.identificador = "1804002005";
            cliente.correo = "osmancruz187@gmail.com";
            cliente.pais = "Guatemala";
            cliente.ciudad = "Guatemala";
            cliente.salario = 3500;
            cliente.idRubro = 1;

            var operaciones = new OperacionesCliente();

            operaciones.crear(cliente);

            double ISR = operaciones.calcularISR(cliente);

            Console.WriteLine("************************************");
            Console.WriteLine("Calculo de ISR");
            Console.WriteLine("************************************");
            Console.WriteLine("\n");
            Console.WriteLine($"El cliente: {cliente.nombre} {cliente.apellido} Paga un impuesto ISR de Q{ISR}");

            Console.WriteLine("*************************************************************************************");

            Console.ReadKey();
        }
    }
}
