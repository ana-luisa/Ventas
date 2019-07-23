using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             //Ciudad
            var ciudad1 = new Ciudad();
            ciudad1.Id = 1;
            ciudad1.Nombre = "San Pedro";

            var ciudad2 = new Ciudad();
            ciudad2.Id = 2;
            ciudad2.Nombre = "El Progreso";

            //Cliente
            var cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Ana Luisa Moreno";
            cliente1.Telefono = "9467-5677";
            cliente1.Ciudad = ciudad1;

            Cliente cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre = "Carlos Cardona";
            cliente2.Telefono = "9548-6328";
            cliente2.Ciudad = ciudad1;


            Cliente cliente3 = new Cliente();
            cliente3.Id = 3;
            cliente3.Nombre = "Reyna Ramirez";
            cliente3.Telefono = "9956-8741";
            cliente3.Ciudad = ciudad2;



            var listadeClientes = new List<Cliente>();
            listadeClientes.Add(cliente1);
            listadeClientes.Add(cliente2);
            listadeClientes.Add(cliente3);

            foreach (var c in listadeClientes) 

            {
                MessageBox.Show(c.Id + " " + c.Nombre + " " + c.Telefono + c.Ciudad.Nombre);
            }


        
        }
    }
}

    