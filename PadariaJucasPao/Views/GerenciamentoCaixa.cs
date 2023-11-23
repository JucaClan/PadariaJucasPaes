using MySqlConnector;
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
using static System.Windows.Forms.LinkLabel;

namespace PadariaJucasPao.Views
{
    public partial class GerenciamentoCaixa : Form
    {
        Classes.Usuario usuario = new Classes.Usuario();

        public GerenciamentoCaixa(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //ativar o botão de encerrar comanda de acordo com o CHECKED
            btnEncerrarComanda.Enabled = chbPagamentoRecebido.Checked;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
         if (txtComanda.Text == "")
            {
                MessageBox.Show("Digite o némero da comanda ","error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
         else
            {
                Classes.OrdemComanda ordemComanda = new Classes.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txtComanda.Text);
                var r = ordemComanda.BuscarFicha();
                dgvComandas.DataSource = r;
                //atualizar o valor total
                lblTotal.Text = r.Compute("SUM(Total_Item)", "true").ToString();

            }
        }

        private void btnEncerrarComanda_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja encerrar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Classes.OrdemComanda ordemComanda = new Classes.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txtComanda.Text);
                
                if(ordemComanda.FecharComanda() == true)
                {
                    MessageBox.Show("Ficha encerrada!", "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //limpar
                    txtComanda.Clear();
                    dgvComandas.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a ficha!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvComandas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
