﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocio;
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private CN_Productos objetoCN = new CN_Productos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarproductos();
        }
        private void mostrarproductos()
        {
            dataGridView1.DataSource = objetoCN.mostrarproducto();
        }
    }
}
