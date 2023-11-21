namespace PadariaJucasPao
{
    partial class MenuPrincipal
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
            this.btnComandas = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComandas
            // 
            this.btnComandas.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnComandas.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComandas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComandas.Location = new System.Drawing.Point(21, 132);
            this.btnComandas.Name = "btnComandas";
            this.btnComandas.Size = new System.Drawing.Size(194, 114);
            this.btnComandas.TabIndex = 0;
            this.btnComandas.Text = "Comandas";
            this.btnComandas.UseVisualStyleBackColor = false;
            this.btnComandas.Click += new System.EventHandler(this.btnComandas_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProdutos.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProdutos.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProdutos.Location = new System.Drawing.Point(233, 131);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(194, 115);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCaixa.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCaixa.Location = new System.Drawing.Point(22, 251);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(404, 39);
            this.btnCaixa.TabIndex = 2;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = false;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnUsuario.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsuario.Location = new System.Drawing.Point(22, 296);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(404, 38);
            this.btnUsuario.TabIndex = 3;
            this.btnUsuario.Text = "Usuários";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.Location = new System.Drawing.Point(96, 23);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(222, 33);
            this.lblMenuPrincipal.TabIndex = 4;
            this.lblMenuPrincipal.Text = "Menu Principal";
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasVindas.Location = new System.Drawing.Point(86, 79);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(282, 26);
            this.lblBoasVindas.TabIndex = 5;
            this.lblBoasVindas.Text = "Olá, escolha uma opção a baixo";
            this.lblBoasVindas.Click += new System.EventHandler(this.lblBoasVindas_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(450, 353);
            this.Controls.Add(this.lblBoasVindas);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnComandas);
            this.Name = "MenuPrincipal";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComandas;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Label lblBoasVindas;
    }
}