namespace PadariaJucasPao.Views
{
    partial class GerenciamentoProdutos
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
            this.lblGerenciamentoProd = new System.Windows.Forms.Label();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbApagarProd = new System.Windows.Forms.GroupBox();
            this.btnApagarProd = new System.Windows.Forms.Button();
            this.lblApagarProd = new System.Windows.Forms.Label();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.cmbCategoriaCad = new System.Windows.Forms.ComboBox();
            this.txtPrecoCad = new System.Windows.Forms.TextBox();
            this.txtNomeCad = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblCategoriaCad = new System.Windows.Forms.Label();
            this.lblPrecoCad = new System.Windows.Forms.Label();
            this.lblNomeProdCad = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.cmbCategoriaEd = new System.Windows.Forms.ComboBox();
            this.txtPrecoEd = new System.Windows.Forms.TextBox();
            this.txtNomeEd = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblCategoriaEd = new System.Windows.Forms.Label();
            this.lblPrecoEd = new System.Windows.Forms.Label();
            this.lblNomeEd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            this.grbApagarProd.SuspendLayout();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGerenciamentoProd
            // 
            this.lblGerenciamentoProd.AutoSize = true;
            this.lblGerenciamentoProd.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenciamentoProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGerenciamentoProd.Location = new System.Drawing.Point(113, 9);
            this.lblGerenciamentoProd.Name = "lblGerenciamentoProd";
            this.lblGerenciamentoProd.Size = new System.Drawing.Size(455, 45);
            this.lblGerenciamentoProd.TabIndex = 4;
            this.lblGerenciamentoProd.Text = "Gerenciamento de produtos";
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.AllowUserToAddRows = false;
            this.DgvProdutos.AllowUserToDeleteRows = false;
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Location = new System.Drawing.Point(16, 61);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.ReadOnly = true;
            this.DgvProdutos.Size = new System.Drawing.Size(665, 255);
            this.DgvProdutos.TabIndex = 5;
            this.DgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            this.DgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellContentClick);
            // 
            // grbApagarProd
            // 
            this.grbApagarProd.Controls.Add(this.btnApagarProd);
            this.grbApagarProd.Controls.Add(this.lblApagarProd);
            this.grbApagarProd.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApagarProd.Location = new System.Drawing.Point(12, 552);
            this.grbApagarProd.Name = "grbApagarProd";
            this.grbApagarProd.Size = new System.Drawing.Size(673, 112);
            this.grbApagarProd.TabIndex = 9;
            this.grbApagarProd.TabStop = false;
            this.grbApagarProd.Text = "Apagar:";
            // 
            // btnApagarProd
            // 
            this.btnApagarProd.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnApagarProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnApagarProd.Location = new System.Drawing.Point(360, 46);
            this.btnApagarProd.Name = "btnApagarProd";
            this.btnApagarProd.Size = new System.Drawing.Size(284, 37);
            this.btnApagarProd.TabIndex = 4;
            this.btnApagarProd.Text = "Apagar";
            this.btnApagarProd.UseVisualStyleBackColor = false;
            this.btnApagarProd.Click += new System.EventHandler(this.btnApagarProd_Click);
            // 
            // lblApagarProd
            // 
            this.lblApagarProd.AutoSize = true;
            this.lblApagarProd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagarProd.Location = new System.Drawing.Point(45, 56);
            this.lblApagarProd.Name = "lblApagarProd";
            this.lblApagarProd.Size = new System.Drawing.Size(221, 19);
            this.lblApagarProd.TabIndex = 0;
            this.lblApagarProd.Text = "Selecione o produto para apagar.";
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.cmbCategoriaCad);
            this.grbCadastrar.Controls.Add(this.txtPrecoCad);
            this.grbCadastrar.Controls.Add(this.txtNomeCad);
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.lblCategoriaCad);
            this.grbCadastrar.Controls.Add(this.lblPrecoCad);
            this.grbCadastrar.Controls.Add(this.lblNomeProdCad);
            this.grbCadastrar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastrar.Location = new System.Drawing.Point(12, 345);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(334, 201);
            this.grbCadastrar.TabIndex = 10;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar:";
            // 
            // cmbCategoriaCad
            // 
            this.cmbCategoriaCad.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaCad.FormattingEnabled = true;
            this.cmbCategoriaCad.Location = new System.Drawing.Point(148, 92);
            this.cmbCategoriaCad.Name = "cmbCategoriaCad";
            this.cmbCategoriaCad.Size = new System.Drawing.Size(178, 23);
            this.cmbCategoriaCad.TabIndex = 6;
            // 
            // txtPrecoCad
            // 
            this.txtPrecoCad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecoCad.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCad.Location = new System.Drawing.Point(148, 69);
            this.txtPrecoCad.Multiline = true;
            this.txtPrecoCad.Name = "txtPrecoCad";
            this.txtPrecoCad.Size = new System.Drawing.Size(178, 17);
            this.txtPrecoCad.TabIndex = 5;
            // 
            // txtNomeCad
            // 
            this.txtNomeCad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeCad.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCad.Location = new System.Drawing.Point(148, 46);
            this.txtNomeCad.Multiline = true;
            this.txtNomeCad.Name = "txtNomeCad";
            this.txtNomeCad.Size = new System.Drawing.Size(178, 17);
            this.txtNomeCad.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Location = new System.Drawing.Point(20, 136);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(284, 42);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCategoriaCad
            // 
            this.lblCategoriaCad.AutoSize = true;
            this.lblCategoriaCad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaCad.Location = new System.Drawing.Point(67, 95);
            this.lblCategoriaCad.Name = "lblCategoriaCad";
            this.lblCategoriaCad.Size = new System.Drawing.Size(76, 19);
            this.lblCategoriaCad.TabIndex = 2;
            this.lblCategoriaCad.Text = "Categoria:";
            // 
            // lblPrecoCad
            // 
            this.lblPrecoCad.AutoSize = true;
            this.lblPrecoCad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCad.Location = new System.Drawing.Point(93, 70);
            this.lblPrecoCad.Name = "lblPrecoCad";
            this.lblPrecoCad.Size = new System.Drawing.Size(49, 19);
            this.lblPrecoCad.TabIndex = 1;
            this.lblPrecoCad.Text = "Preço:";
            // 
            // lblNomeProdCad
            // 
            this.lblNomeProdCad.AutoSize = true;
            this.lblNomeProdCad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProdCad.Location = new System.Drawing.Point(17, 46);
            this.lblNomeProdCad.Name = "lblNomeProdCad";
            this.lblNomeProdCad.Size = new System.Drawing.Size(125, 19);
            this.lblNomeProdCad.TabIndex = 0;
            this.lblNomeProdCad.Text = "Nome do produto:";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.cmbCategoriaEd);
            this.grbEditar.Controls.Add(this.txtPrecoEd);
            this.grbEditar.Controls.Add(this.txtNomeEd);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.lblCategoriaEd);
            this.grbEditar.Controls.Add(this.lblPrecoEd);
            this.grbEditar.Controls.Add(this.lblNomeEd);
            this.grbEditar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.Location = new System.Drawing.Point(351, 346);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(334, 201);
            this.grbEditar.TabIndex = 11;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar:";
            // 
            // cmbCategoriaEd
            // 
            this.cmbCategoriaEd.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaEd.FormattingEnabled = true;
            this.cmbCategoriaEd.Location = new System.Drawing.Point(148, 92);
            this.cmbCategoriaEd.Name = "cmbCategoriaEd";
            this.cmbCategoriaEd.Size = new System.Drawing.Size(178, 23);
            this.cmbCategoriaEd.TabIndex = 6;
            // 
            // txtPrecoEd
            // 
            this.txtPrecoEd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecoEd.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoEd.Location = new System.Drawing.Point(148, 69);
            this.txtPrecoEd.Multiline = true;
            this.txtPrecoEd.Name = "txtPrecoEd";
            this.txtPrecoEd.Size = new System.Drawing.Size(178, 17);
            this.txtPrecoEd.TabIndex = 5;
            // 
            // txtNomeEd
            // 
            this.txtNomeEd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeEd.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEd.Location = new System.Drawing.Point(148, 46);
            this.txtNomeEd.Multiline = true;
            this.txtNomeEd.Name = "txtNomeEd";
            this.txtNomeEd.Size = new System.Drawing.Size(178, 17);
            this.txtNomeEd.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Location = new System.Drawing.Point(20, 136);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(284, 42);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblCategoriaEd
            // 
            this.lblCategoriaEd.AutoSize = true;
            this.lblCategoriaEd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaEd.Location = new System.Drawing.Point(67, 94);
            this.lblCategoriaEd.Name = "lblCategoriaEd";
            this.lblCategoriaEd.Size = new System.Drawing.Size(76, 19);
            this.lblCategoriaEd.TabIndex = 2;
            this.lblCategoriaEd.Text = "Categoria:";
            // 
            // lblPrecoEd
            // 
            this.lblPrecoEd.AutoSize = true;
            this.lblPrecoEd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoEd.Location = new System.Drawing.Point(93, 68);
            this.lblPrecoEd.Name = "lblPrecoEd";
            this.lblPrecoEd.Size = new System.Drawing.Size(49, 19);
            this.lblPrecoEd.TabIndex = 1;
            this.lblPrecoEd.Text = "Preço:";
            // 
            // lblNomeEd
            // 
            this.lblNomeEd.AutoSize = true;
            this.lblNomeEd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEd.Location = new System.Drawing.Point(17, 46);
            this.lblNomeEd.Name = "lblNomeEd";
            this.lblNomeEd.Size = new System.Drawing.Size(125, 19);
            this.lblNomeEd.TabIndex = 0;
            this.lblNomeEd.Text = "Nome do produto:";
            // 
            // GerenciamentoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(694, 666);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.grbApagarProd);
            this.Controls.Add(this.DgvProdutos);
            this.Controls.Add(this.lblGerenciamentoProd);
            this.Name = "GerenciamentoProdutos";
            this.Text = "GerenciamentoProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.grbApagarProd.ResumeLayout(false);
            this.grbApagarProd.PerformLayout();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGerenciamentoProd;
        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.GroupBox grbApagarProd;
        private System.Windows.Forms.Button btnApagarProd;
        private System.Windows.Forms.Label lblApagarProd;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.TextBox txtPrecoCad;
        private System.Windows.Forms.TextBox txtNomeCad;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCategoriaCad;
        private System.Windows.Forms.Label lblPrecoCad;
        private System.Windows.Forms.Label lblNomeProdCad;
        private System.Windows.Forms.ComboBox cmbCategoriaCad;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.ComboBox cmbCategoriaEd;
        private System.Windows.Forms.TextBox txtPrecoEd;
        private System.Windows.Forms.TextBox txtNomeEd;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblCategoriaEd;
        private System.Windows.Forms.Label lblPrecoEd;
        private System.Windows.Forms.Label lblNomeEd;
    }
}