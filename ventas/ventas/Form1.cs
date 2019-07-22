﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Categorias
            var categoria1 = new Categoria();
            categoria1.Id = 1;
            categoria1.Nombre = "Celulares";

            var categoria2 = new Categoria();
            categoria2.Id = 2;
            categoria2.Nombre = "Accesorio";

            //Producto
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Celular LG";
            producto1.Precio = 10000;
            producto1.Categoria = categoria1;

            Producto producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Celular Samsung";
            producto2.Precio = 8000;
            producto2.Categoria = categoria1;

            Producto producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Audifonos";
            producto3.Precio = 200;
            producto3.Categoria = categoria2;



            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            foreach (var p in listadeProductos)

            {
                MessageBox.Show(p.Descripcion + " " + p.Categoria.Nombre);
            }


        
        }
    }
}
