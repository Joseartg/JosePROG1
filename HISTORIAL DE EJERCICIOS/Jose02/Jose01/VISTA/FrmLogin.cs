
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jose01.DOMINIO;
using Jose01.NEGOCIO;
using Jose01.VISTA;

namespace Jose01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            log.Usuario = txtUser.Text;
            log.Usuario = txtPass.Text;

            ClsLogin clsL = new ClsLogin();

            int variabledeevaluacion = clsL.acceso(log);

            if (variabledeevaluacion==1) {

                MessageBox.Show("Welcome");
                FrmMenu frm = new FrmMenu();
                frm.Show();
                this.Hide();
            
            }
            else
            {
                MessageBox.Show("False");
            }
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
