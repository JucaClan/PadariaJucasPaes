namespace PadariaJucasPao.Views
{
    partial class GerenciamentoCaixa
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
            this.lblNComanda = new System.Windows.Forms.Label();
            this.txtComanda = new System.Windows.Forms.TextBox();
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.lblReais = new System.Windows.Forms.Label();
            this.chbPagamentoRecebido = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEncerrarComanda = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNComanda
            // 
            this.lblNComanda.AutoSize = true;
            this.lblNComanda.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNComanda.Location = new System.Drawing.Point(12, 41);
            this.lblNComanda.Name = "lblNComanda";
            this.lblNComanda.Size = new System.Drawing.Size(194, 39);
            this.lblNComanda.TabIndex = 0;
            this.lblNComanda.Text = "Nº Comanda:";
            // 
            // txtComanda
            // 
            this.txtComanda.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComanda.Location = new System.Drawing.Point(212, 33);
            this.txtComanda.Name = "txtComanda";
            this.txtComanda.Size = new System.Drawing.Size(269, 47);
            this.txtComanda.TabIndex = 1;
            // 
            // dgvComandas
            // 
            this.dgvComandas.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Location = new System.Drawing.Point(14, 95);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.Size = new System.Drawing.Size(652, 253);
            this.dgvComandas.TabIndex = 2;
            this.dgvComandas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComandas_CellClick);
            // 
            // lblReais
            // 
            this.lblReais.AutoSize = true;
            this.lblReais.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReais.Location = new System.Drawing.Point(12, 363);
            this.lblReais.Name = "lblReais";
            this.lblReais.Size = new System.Drawing.Size(60, 39);
            this.lblReais.TabIndex = 3;
            this.lblReais.Text = "R$:";
            // 
            // chbPagamentoRecebido
            // 
            this.chbPagamentoRecebido.AutoSize = true;
            this.chbPagamentoRecebido.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPagamentoRecebido.Location = new System.Drawing.Point(478, 374);
            this.chbPagamentoRecebido.Name = "chbPagamentoRecebido";
            this.chbPagamentoRecebido.Size = new System.Drawing.Size(186, 27);
            this.chbPagamentoRecebido.TabIndex = 5;
            this.chbPagamentoRecebido.Text = "PagamentoRecebido";
            this.chbPagamentoRecebido.UseVisualStyleBackColor = true;
            this.chbPagamentoRecebido.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(61, 363);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 39);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "0,00";
            // 
            // btnEncerrarComanda
            // 
            this.btnEncerrarComanda.BackColor = System.Drawing.Color.Chocolate;
            this.btnEncerrarComanda.Enabled = false;
            this.btnEncerrarComanda.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrarComanda.Location = new System.Drawing.Point(487, 416);
            this.btnEncerrarComanda.Name = "btnEncerrarComanda";
            this.btnEncerrarComanda.Size = new System.Drawing.Size(156, 36);
            this.btnEncerrarComanda.TabIndex = 7;
            this.btnEncerrarComanda.Text = "Encerrar comanda";
            this.btnEncerrarComanda.UseVisualStyleBackColor = false;
            this.btnEncerrarComanda.Click += new System.EventHandler(this.btnEncerrarComanda_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnPesquisar.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(487, 33);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(153, 49);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // GerenciamentoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(679, 482);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnEncerrarComanda);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chbPagamentoRecebido);
            this.Controls.Add(this.lblReais);
            this.Controls.Add(this.dgvComandas);
            this.Controls.Add(this.txtComanda);
            this.Controls.Add(this.lblNComanda);
            this.Name = "GerenciamentoCaixa";
            this.Text = " Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNComanda;
        private System.Windows.Forms.TextBox txtComanda;
        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.Label lblReais;
        private System.Windows.Forms.CheckBox chbPagamentoRecebido;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEncerrarComanda;
        private System.Windows.Forms.Button btnPesquisar;
    }
}