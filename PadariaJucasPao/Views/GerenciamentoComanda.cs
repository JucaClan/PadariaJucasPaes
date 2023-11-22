using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaJucasPao.Views
{
    public partial class GerenciamentoComanda : Form
    {
        Classes.Usuario usuario = new Classes.Usuario();
        public GerenciamentoComanda(Classes.Usuario usuario)
        {

            InitializeComponent();
            this.usuario = usuario;
            this.Text = "Gerenciamento comandas - Logado como: " + usuario.NomeCompleto.ToUpper();

            //popular o dgv com os dados da tabela produtos
            Classes.Produto produto = new Classes.Produto();
            dgvComandas.DataSource = produto.ListarTudoProd();
        }

        private void dgvComandas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // obter a linha clicada:
            int linhaSelecionada = dgvComandas.CurrentCell.RowIndex;
            var linha = dgvComandas.Rows[linhaSelecionada];



            // Preencher os campos dos txts com os valores do DGV:
            txtProduto.Text = linha.Cells[0].Value.ToString();
            txtProdutoL.Text = linha.Cells[1].Value.ToString();


        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            grbLancamento.Enabled = true;
            grbInformacoes.Enabled = false;
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja lançar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                Classes.OrdemComanda ordemComanda = new Classes.OrdemComanda();
                //obter os valores dos campos:
                ordemComanda.IdFicha = int.Parse(txtComanda.Text);
                ordemComanda.IdProduto = int.Parse(txtProduto.Text);
                ordemComanda.Quantidade = int.Parse(txtQuantidadeL.Text);
                ordemComanda.IdResp = usuario.Id;

                //efetuar o cadastro
                if (ordemComanda.NovoLancamento() == true)
                {
                    MessageBox.Show("Lançamento efetuado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //
                    grbLancamento.Enabled = false;
                    grbInformacoes.Enabled = true;
                    txtProduto.Clear();
                    txtQuantidadeL.Clear();
                }
                else
                {
                    MessageBox.Show("lançamento efetuado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
