﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosales_WaterLevel_Monitor.Views
{
    public partial class frm_usuarios : Form
    {
        public frm_usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'monitoreoAguaDataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter.Fill(this.monitoreoAguaDataSet.USUARIOS);
            // TODO: esta línea de código carga datos en la tabla 'monitoreoAguaDataSet.REGISTRO' Puede moverla o quitarla según sea necesario.
            this.rEGISTROTableAdapter.Fill(this.monitoreoAguaDataSet.REGISTRO);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_MenuPrincipal menu = new frm_MenuPrincipal();
            menu.ShowDialog();
            
        }
    }
}
