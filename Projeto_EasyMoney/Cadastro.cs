using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EasyMoney
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            toolNovo.Enabled = true;
            toolSalvar.Enabled = false;
            toolCancelar.Enabled = false;
            toolExcluir.Enabled = false;
            textID.Enabled = false;
            toolBuscaID.Enabled = true;
            comboBoxCategoria.Enabled = false;
            textValor.Enabled = false;
            textDescrição.Enabled = false;
            boxData.Enabled = false;
            }

        private void toolNovo_Click(object sender, EventArgs e)
        {
            toolNovo.Enabled = false;
            toolSalvar.Enabled = true;
            toolCancelar.Enabled = true;
            toolExcluir.Enabled = false;
            textID.Enabled = false;
            toolBuscaID.Enabled = false;
            comboBoxCategoria.Enabled = true;
            textValor.Enabled = true;
            textDescrição.Enabled = true;
            boxData.Enabled = true;
        }

        private void textValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
