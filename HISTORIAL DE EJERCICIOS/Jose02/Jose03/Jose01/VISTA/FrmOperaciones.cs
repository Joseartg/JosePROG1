﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jose01.VISTA
{
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {

            try
            {
                int suma;
                suma = Convert.ToInt32(txtDato1.Text) + Convert.ToInt32(txtDato2.Text);

                txtResultado.Text = suma.ToString();

            } catch (Exception ex ) {

                MessageBox.Show("Revisa bien tus datos");

            }

            //txtResultado.Text = txtDato1.Text + txtDato2.Text;
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {

        }
    }
}
