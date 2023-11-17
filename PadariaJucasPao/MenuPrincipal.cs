using PadariaJucasPao.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaJucasPao
{
    public partial class MenuPrincipal : Form
    {
        // Objetos globais:
        Classes.Usuario usuario = new Classes.Usuario();
        public MenuPrincipal(Classes.Usuario usuario)
        {
            InitializeComponent();
            // Atribuir o usuário local no global:
            this.usuario = usuario;

            // Mudar a label de apresentação:
            lblBoasVindas.Text = "Olá, " + usuario.NomeCompleto + " escolha uma opção a baixo.";

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            // Instanciar a janela:
            Views.GerenciadorUsuarios janela = new Views.GerenciadorUsuarios();
            janela.Show();

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            // Instanciar a janela:
            Views.GerenciamentoProdutos janela = new Views.GerenciamentoProdutos(usuario);
            janela.Show();
        }

        private void lblBoasVindas_Click(object sender, EventArgs e)
        {

        }
    }
}
