using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade.ViewMay
{
    public partial class tela2Mayandra : Form
    {
        public tela2Mayandra()
        {
            InitializeComponent();
        }

        private void tela2Mayandra_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (tbxNome.SelectedText == "")
            {
                MessageBox.Show("Preencha Todos os Campos");
            }
        }
    }
}
