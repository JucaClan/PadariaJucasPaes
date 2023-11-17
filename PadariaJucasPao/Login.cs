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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Instanciar um usuário:
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Email = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;

            //obter o resultado do select no banco
            var resultado = usuario.Logar();

            if (resultado.Rows.Count == 1)
            {
                //senha correta
                usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                usuario.Id =(int)resultado.Rows[0]["id"];
                
                //abrir a janela MENU:
                MenuPrincipal janela = new MenuPrincipal(usuario);
                janela.ShowDialog();
                //ESCONDER JANELA ATUAL
                Hide();
                //MOSTRAR O LOGIN QUANDO O MENU FECHAR
                Show();
            }
            else
            {
                //senha incorreta
                MessageBox.Show("Email ou senha incorreta! ","ERRO ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
