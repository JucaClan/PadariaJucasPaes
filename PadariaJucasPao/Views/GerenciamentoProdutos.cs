using PadariaJucasPao.Classes;
using System;
using System.Collections;
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
    public partial class GerenciamentoProdutos : Form
    {
        // Atributos globais:
        int idSelecionado = 0;
        Classes.Usuario usuario = new Classes.Usuario();
        public GerenciamentoProdutos(Classes.Usuario usuario)
        {
            InitializeComponent();
            Classes.Produto produto = new Classes.Produto();
            this.usuario = usuario;
            // Atribuir a tabela (resultado do SELECT) no DGV:
            DgvProdutos.DataSource = produto.ListarTudoProd();

            Classes.Categoria categoria = new Classes.Categoria();
            //Montar um array de itens para colocar no cmb
            var r = categoria.ListarTudo(); // r é a tabela do bd

            
            //percorrer o R, montar a string e adicionar ao CMB
            foreach (DataRow linha in r.Rows)
            {
                cmbCategoriaEd.Items.Add(linha.ItemArray[0].ToString() + " - " + linha.ItemArray[1].ToString());
                cmbCategoriaCad.Items.Add(linha.ItemArray[0].ToString() + " - " + linha.ItemArray[1].ToString());
            }
            

        }

        private void btnApagarProd_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();
            produto.Id = idSelecionado;
            // Exibir mensagem de confirmação da exclusão:
            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {//Apagar

                if (produto.Apagar() == true)
                {
                    MessageBox.Show("Produto apagado! ", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //atualizar odgv:
                    DgvProdutos.DataSource = produto.ListarTudoProd();
                    // Limpar os campos:
                    txtNomeCad.Clear();
                    txtPrecoCad.Clear();
                    lblApagarProd.Text = "Selecione o Produto para apagar.";
                    //Desabilitar os grbs
                    grbApagarProd.Enabled = false;
                    grbEditar.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Falha ao remover produto! ", "Falha",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar os grbs:
            grbEditar.Enabled = true;
            grbApagarProd.Enabled = true;

            // obter a linha clicada:
            int linhaSelecionada = DgvProdutos.CurrentCell.RowIndex;

            // Armazenar os dados da linha seleciona em "linha" (tipo um vetor)
            var linha = DgvProdutos.Rows[linhaSelecionada];

            // Preencher os campos:
            txtNomeEd.Text = linha.Cells[1].Value.ToString();
            txtPrecoEd.Text = linha.Cells[2].Value.ToString();
            //cmbCategoriaEd.Text = linha.Cells[3].Value.ToString();

            // Juntar o ID e o nome para exibir no apagar:
            lblApagarProd.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            // Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;

        }

        private void gdvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        { //Obter valores dos txts:
            Classes.Produto produto = new Classes.Produto();
            produto.Id = idSelecionado;
            produto.Nome = txtNomeEd.Text;
            produto.Preco = double.Parse(txtPrecoEd.Text);
            produto.IdCategoria = int.Parse(cmbCategoriaEd.Text.Split('-')[0]);
            //Editar:
            if (produto.Editar() == true)
            {
                MessageBox.Show("Produto modificado!", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //atualizar odgv:
                DgvProdutos.DataSource = produto.ListarTudoProd();
                //limpar os campos de edição
                txtNomeEd.Clear();
                txtPrecoEd.Clear();
               // cmbCategoriaEd.Clear(1);
                lblApagarProd.Text = "Selecione o produto para apagar.";
                //Desabilitar os grbs
                grbApagarProd.Enabled = false;
                grbEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Falha ao modificar Produto!", "falha", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Instanciar o usuário:
            Classes.Produto produto = new Classes.Produto();

            // Obter os valores dos campos:
            produto.Nome = txtNomeCad.Text;
            produto.Preco = Double.Parse(txtPrecoCad.Text);
            produto.IdCategoria = int.Parse(cmbCategoriaCad.Text.Split('-')[0]);
            produto.IdRespCadastro = usuario.Id;
            if (produto.CadastrarProduto() == true)
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
                // Limpar os campos:
                txtNomeCad.Clear();
                txtPrecoCad.Clear();

                // Atualizar o dgv:
                DgvProdutos.DataSource = produto.ListarTudoProd();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar produto!");
            }

           
        }

        private void DgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
