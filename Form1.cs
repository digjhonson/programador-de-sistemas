using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alertas
{
    public partial class frmAlertas : Form
    {
        public frmAlertas()
        {
            InitializeComponent();
        }

        private void btnAlertaSimples_Click(object sender, EventArgs e)
        {
            MessageBox.Show("alerta simples", "titulo");
        }


        private void btnAlertaRobusto_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("vamos programar um sistema", "titulo aqui", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (resposta == DialogResult.Yes) 
            {
                MessageBox.Show("Respondeu que sim");
            } 
            else if (resposta == DialogResult.No)
            {
                MessageBox.Show("respondeu não!");
            }
        }
    }
}