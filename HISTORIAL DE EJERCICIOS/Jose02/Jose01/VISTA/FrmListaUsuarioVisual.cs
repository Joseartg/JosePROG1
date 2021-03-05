using Jose01.DAO;
using System;
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
    public partial class FrmListaUsuarioVisual : Form
    {
        public FrmListaUsuarioVisual()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmListaUsuarioVisual_Load(object sender, EventArgs e)
        {
            ClsListaUsuario cls = new ClsListaUsuario();
            foreach (var iteracion in cls.user)
            {
                dataGridView1.Rows.Add(iteracion.ToString());
            }
        }
    }
}
