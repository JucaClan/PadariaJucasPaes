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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //Instanciar a janela de login
            Login janela = new Login(); 
            //mostrar janela
            janela.ShowDialog();
            //Fechar tudo ao fechar a login
            Application.Exit();

        }
    }
}
