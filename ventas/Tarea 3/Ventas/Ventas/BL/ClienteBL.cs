using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ClienteBL
    {
        public List<Cliente> ListadeClientes { get; set; }

        public ClienteBL()
        {
            ListadeClientes = new List<Cliente>();
            CrearDatosdePrueba();


        }
        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "El Progreso");
            var ciudad2 = new Ciudad(2, "San Pedro Sula");
            var ciudad3 = new Ciudad(3, "Tegucigalpa");

            var cliente1 = new Cliente(1, "Ana Morenno", 95486328, "Col Bendeck", ciudad1);
            var cliente2 = new Cliente(2, "Reyna Ramirez", 95555555, "Col. Palermo", ciudad3);
            var cliente3 = new Cliente(3, "Raquel Moreno", 97476322, "Col. Paz", ciudad2);

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
        }
    }
}
