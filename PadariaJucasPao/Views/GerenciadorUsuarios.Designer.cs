namespace PadariaJucasPao.Views
{
    partial class GerenciadorUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.txtSenhaCad = new System.Windows.Forms.TextBox();
            this.txtEmailCad = new System.Windows.Forms.TextBox();
            this.txtNomeCompletoCad = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.txtSenhaEd = new System.Windows.Forms.TextBox();
            this.txtEmailEd = new System.Windows.Forms.TextBox();
            this.txtNomeCompletoEd = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(21, 86);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(808, 224);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(145, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(480, 49);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Gerenciamento de Usuários";
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.txtSenhaCad);
            this.grbCadastro.Controls.Add(this.txtEmailCad);
            this.grbCadastro.Controls.Add(this.txtNomeCompletoCad);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.lblSenha);
            this.grbCadastro.Controls.Add(this.lblEmail);
            this.grbCadastro.Controls.Add(this.lblNomeCompleto);
            this.grbCadastro.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastro.Location = new System.Drawing.Point(21, 316);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(334, 193);
            this.grbCadastro.TabIndex = 4;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro:";
            // 
            // txtSenhaCad
            // 
            this.txtSenhaCad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaCad.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCad.Location = new System.Drawing.Point(133, 92);
            this.txtSenhaCad.Multiline = true;
            this.txtSenhaCad.Name = "txtSenhaCad";
            this.txtSenhaCad.Size = new System.Drawing.Size(178, 17);
            this.txtSenhaCad.TabIndex = 6;
            // 
            // txtEmailCad
            // 
            this.txtEmailCad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailCad.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCad.Location = new System.Drawing.Point(133, 69);
            this.txtEmailCad.Multiline = true;
            this.txtEmailCad.Name = "txtEmailCad";
            this.txtEmailCad.Size = new System.Drawing.Size(178, 17);
            this.txtEmailCad.TabIndex = 5;
            // 
            // txtNomeCompletoCad
            // 
            this.txtNomeCompletoCad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeCompletoCad.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCompletoCad.Location = new System.Drawing.Point(133, 46);
            this.txtNomeCompletoCad.Multiline = true;
            this.txtNomeCompletoCad.Name = "txtNomeCompletoCad";
            this.txtNomeCompletoCad.Size = new System.Drawing.Size(178, 17);
            this.txtNomeCompletoCad.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Location = new System.Drawing.Point(19, 136);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(284, 42);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(69, 86);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(58, 23);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(73, 63);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 23);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.Location = new System.Drawing.Point(3, 40);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(124, 23);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome completo:";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.txtSenhaEd);
            this.grbEditar.Controls.Add(this.txtEmailEd);
            this.grbEditar.Controls.Add(this.txtNomeCompletoEd);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.label1);
            this.grbEditar.Controls.Add(this.label2);
            this.grbEditar.Controls.Add(this.label3);
            this.grbEditar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.Location = new System.Drawing.Point(361, 316);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(325, 193);
            this.grbEditar.TabIndex = 7;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar:";
            // 
            // txtSenhaEd
            // 
            this.txtSenhaEd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaEd.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaEd.Location = new System.Drawing.Point(133, 92);
            this.txtSenhaEd.Multiline = true;
            this.txtSenhaEd.Name = "txtSenhaEd";
            this.txtSenhaEd.Size = new System.Drawing.Size(178, 17);
            this.txtSenhaEd.TabIndex = 6;
            // 
            // txtEmailEd
            // 
            this.txtEmailEd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailEd.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailEd.Location = new System.Drawing.Point(133, 69);
            this.txtEmailEd.Multiline = true;
            this.txtEmailEd.Name = "txtEmailEd";
            this.txtEmailEd.Size = new System.Drawing.Size(178, 17);
            this.txtEmailEd.TabIndex = 5;
            // 
            // txtNomeCompletoEd
            // 
            this.txtNomeCompletoEd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeCompletoEd.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCompletoEd.Location = new System.Drawing.Point(133, 46);
            this.txtNomeCompletoEd.Multiline = true;
            this.txtNomeCompletoEd.Name = "txtNomeCompletoEd";
            this.txtNomeCompletoEd.Size = new System.Drawing.Size(178, 17);
            this.txtNomeCompletoEd.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Location = new System.Drawing.Point(19, 136);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(284, 42);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome completo:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApagar.Location = new System.Drawing.Point(21, 515);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(665, 80);
            this.grbApagar.TabIndex = 8;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar:";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnApagar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnApagar.Location = new System.Drawing.Point(359, 24);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(284, 37);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.Location = new System.Drawing.Point(58, 33);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(245, 23);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione o usuário para apagar.";
            // 
            // GerenciadorUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(845, 600);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "GerenciadorUsuarios";
            this.Text = "GerenciadorUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox txtNomeCompletoCad;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtSenhaCad;
        private System.Windows.Forms.TextBox txtEmailCad;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.TextBox txtSenhaEd;
        private System.Windows.Forms.TextBox txtEmailEd;
        private System.Windows.Forms.TextBox txtNomeCompletoEd;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagar;
    }
}