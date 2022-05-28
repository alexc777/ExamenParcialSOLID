using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcialSOLID.Classes
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string identificador { get; set; }
        public string correo { get; set; }
        public string pais { get; set; }
        public string ciudad { get; set; }
        public double salario { get; set; }
        public int idRubro { get; set; }

    }
}
