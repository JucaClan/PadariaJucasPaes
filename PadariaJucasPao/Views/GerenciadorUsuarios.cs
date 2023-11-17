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
    public partial class GerenciadorUsuarios : Form
    {
        // Atributos globais:
        int idSelecionado = 0;
        public GerenciadorUsuarios()
        {
            InitializeComponent();
            Classes.Usuario usuario = new Classes.Usuario();

            // Atribuir a tabela (resultado do SELECT) no DGV:
            dgvUsuarios.DataSource = usuario.ListarTudo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Instanciar o usuário:
            Classes.Usuario usuario = new Classes.Usuario();
            // Obter os valores dos campos:
            usuario.NomeCompleto = txtNomeCompletoCad.Text;
            usuario.Email = txtEmailCad.Text;
            usuario.Senha = txtSenhaCad.Text;

            if (usuario.Cadastrar() == true)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                // Limpar os campos:
                txtNomeCompletoCad.Clear();
                txtEmailCad.Clear();
                txtSenhaCad.Clear();
                // Atualizar o dgv:
                dgvUsuarios.DataSource = usuario.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar usuário!");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Obter valores dos txts:
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id = idSelecionado;
            usuario.NomeCompleto = txtNomeCompletoEd.Text;
            usuario.Email = txtEmailEd.Text;
            usuario.Senha = txtSenhaEd.Text;

            //Editar:
            if (usuario.Editar() == true)
            {
                MessageBox.Show("Usuário modificado!", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //atualizar odgv:
                dgvUsuarios.DataSource = usuario.ListarTudo();
                //limpar os campos de edição
                txtNomeCompletoCad.Clear();
                txtEmailCad.Clear();
                txtSenhaCad.Clear();
                lblApagar.Text = "Selecione o usuário para apagar.";
                //Desabilitar os grbs
                grbApagar.Enabled = false;
                grbEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Falha ao modificar usuário!", "falha", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id = idSelecionado;
            // Exibir mensagem de confirmação da exclusão:
            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {//Apagar

                if (usuario.Apagar() == true)
                {
                    MessageBox.Show("Usuário apagado! ", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //atualizar odgv:
                    dgvUsuarios.DataSource = usuario.ListarTudo();
                    // Limpar os campos:
                    txtNomeCompletoCad.Clear();
                    txtEmailCad.Clear();
                    txtSenhaCad.Clear();
                    lblApagar.Text = "Selecione o usuário para apagar.";
                    //Desabilitar os grbs
                    grbApagar.Enabled = false;
                    grbEditar.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Falha ao remover usuário! ", "Falha",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar os grbs:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;

            // obter a linha clicada:
            int linhaSelecionada = dgvUsuarios.CurrentCell.RowIndex;

            // Armazenar os dados da linha seleciona em "linha" (tipo um vetor)
            var linha = dgvUsuarios.Rows[linhaSelecionada];

            // Preencher os campos:
            txtNomeCompletoEd.Text = linha.Cells[1].Value.ToString();
            txtEmailEd.Text = linha.Cells[2].Value.ToString();

            // Juntar o ID e o nome para exibir no apagar:
            lblApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            // Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
