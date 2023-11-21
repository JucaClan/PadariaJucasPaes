namespace PadariaJucasPao.Views
{
    partial class GerenciamentoComanda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblComanda = new System.Windows.Forms.Label();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtComando = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.grbLancamento = new System.Windows.Forms.GroupBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txtQuantidadeL = new System.Windows.Forms.TextBox();
            this.txtProdutoL = new System.Windows.Forms.TextBox();
            this.lblQuantidadeL = new System.Windows.Forms.Label();
            this.lblProdutoL = new System.Windows.Forms.Label();
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.lblGerenciamentoDeComandas = new System.Windows.Forms.Label();
            this.grbInformacoes.SuspendLayout();
            this.grbLancamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(6, 48);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(114, 29);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "Comanda:";
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbInformacoes.Controls.Add(this.btnContinuar);
            this.grbInformacoes.Controls.Add(this.txtProduto);
            this.grbInformacoes.Controls.Add(this.txtComando);
            this.grbInformacoes.Controls.Add(this.lblProduto);
            this.grbInformacoes.Controls.Add(this.lblComanda);
            this.grbInformacoes.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInformacoes.Location = new System.Drawing.Point(16, 71);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(259, 304);
            this.grbInformacoes.TabIndex = 1;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(21, 99);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(99, 29);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto:";
            // 
            // txtComando
            // 
            this.txtComando.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComando.Location = new System.Drawing.Point(126, 48);
            this.txtComando.Name = "txtComando";
            this.txtComando.Size = new System.Drawing.Size(111, 33);
            this.txtComando.TabIndex = 2;
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(126, 99);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(111, 33);
            this.txtProduto.TabIndex = 3;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnContinuar.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(39, 190);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(179, 42);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            // 
            // grbLancamento
            // 
            this.grbLancamento.Controls.Add(this.btnLancar);
            this.grbLancamento.Controls.Add(this.txtQuantidadeL);
            this.grbLancamento.Controls.Add(this.txtProdutoL);
            this.grbLancamento.Controls.Add(this.lblQuantidadeL);
            this.grbLancamento.Controls.Add(this.lblProdutoL);
            this.grbLancamento.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLancamento.Location = new System.Drawing.Point(16, 337);
            this.grbLancamento.Name = "grbLancamento";
            this.grbLancamento.Size = new System.Drawing.Size(259, 242);
            this.grbLancamento.TabIndex = 5;
            this.grbLancamento.TabStop = false;
            this.grbLancamento.Text = "Lançameto:";
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLancar.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.Location = new System.Drawing.Point(39, 181);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(179, 42);
            this.btnLancar.TabIndex = 4;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = false;
            // 
            // txtQuantidadeL
            // 
            this.txtQuantidadeL.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeL.Location = new System.Drawing.Point(148, 95);
            this.txtQuantidadeL.Name = "txtQuantidadeL";
            this.txtQuantidadeL.Size = new System.Drawing.Size(111, 33);
            this.txtQuantidadeL.TabIndex = 3;
            // 
            // txtProdutoL
            // 
            this.txtProdutoL.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutoL.Location = new System.Drawing.Point(148, 48);
            this.txtProdutoL.Name = "txtProdutoL";
            this.txtProdutoL.Size = new System.Drawing.Size(111, 33);
            this.txtProdutoL.TabIndex = 2;
            // 
            // lblQuantidadeL
            // 
            this.lblQuantidadeL.AutoSize = true;
            this.lblQuantidadeL.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeL.Location = new System.Drawing.Point(6, 99);
            this.lblQuantidadeL.Name = "lblQuantidadeL";
            this.lblQuantidadeL.Size = new System.Drawing.Size(136, 29);
            this.lblQuantidadeL.TabIndex = 1;
            this.lblQuantidadeL.Text = "Quantidade:";
            // 
            // lblProdutoL
            // 
            this.lblProdutoL.AutoSize = true;
            this.lblProdutoL.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoL.Location = new System.Drawing.Point(34, 48);
            this.lblProdutoL.Name = "lblProdutoL";
            this.lblProdutoL.Size = new System.Drawing.Size(99, 29);
            this.lblProdutoL.TabIndex = 0;
            this.lblProdutoL.Text = "Produto:";
            // 
            // dgvComandas
            // 
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Location = new System.Drawing.Point(309, 78);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.Size = new System.Drawing.Size(469, 500);
            this.dgvComandas.TabIndex = 6;
            // 
            // lblGerenciamentoDeComandas
            // 
            this.lblGerenciamentoDeComandas.AutoSize = true;
            this.lblGerenciamentoDeComandas.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenciamentoDeComandas.Location = new System.Drawing.Point(138, 9);
            this.lblGerenciamentoDeComandas.Name = "lblGerenciamentoDeComandas";
            this.lblGerenciamentoDeComandas.Size = new System.Drawing.Size(509, 49);
            this.lblGerenciamentoDeComandas.TabIndex = 7;
            this.lblGerenciamentoDeComandas.Text = "Gerenciamento de comandas:";
            // 
            // GerenciamentoComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(790, 590);
            this.Controls.Add(this.lblGerenciamentoDeComandas);
            this.Controls.Add(this.dgvComandas);
            this.Controls.Add(this.grbLancamento);
            this.Controls.Add(this.grbInformacoes);
            this.Name = "GerenciamentoComanda";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoComanda";
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbLancamento.ResumeLayout(false);
            this.grbLancamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtComando;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.GroupBox grbLancamento;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txtQuantidadeL;
        private System.Windows.Forms.TextBox txtProdutoL;
        private System.Windows.Forms.Label lblQuantidadeL;
        private System.Windows.Forms.Label lblProdutoL;
        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.Label lblGerenciamentoDeComandas;
    }
}