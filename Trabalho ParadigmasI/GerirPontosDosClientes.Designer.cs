namespace Trabalho_ParadigmasI
{
    partial class GerirPontosDosClientes
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
            this.ButtonGerirPontosVoltar = new System.Windows.Forms.Button();
            this.ButtonConsultarSaldo = new System.Windows.Forms.Button();
            this.ButtonConsultarCompras = new System.Windows.Forms.Button();
            this.ButtonRegistarCompras = new System.Windows.Forms.Button();
            this.ButtonAtribuirCartao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonGerirPontosVoltar
            // 
            this.ButtonGerirPontosVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGerirPontosVoltar.Location = new System.Drawing.Point(262, 346);
            this.ButtonGerirPontosVoltar.Name = "ButtonGerirPontosVoltar";
            this.ButtonGerirPontosVoltar.Size = new System.Drawing.Size(96, 30);
            this.ButtonGerirPontosVoltar.TabIndex = 19;
            this.ButtonGerirPontosVoltar.Text = "Voltar";
            this.ButtonGerirPontosVoltar.UseVisualStyleBackColor = true;
            this.ButtonGerirPontosVoltar.Click += new System.EventHandler(this.ButtonGerirPontosVoltar_Click);
            // 
            // ButtonConsultarSaldo
            // 
            this.ButtonConsultarSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConsultarSaldo.Location = new System.Drawing.Point(203, 276);
            this.ButtonConsultarSaldo.Name = "ButtonConsultarSaldo";
            this.ButtonConsultarSaldo.Size = new System.Drawing.Size(217, 34);
            this.ButtonConsultarSaldo.TabIndex = 18;
            this.ButtonConsultarSaldo.Text = "Consultar saldo de um cartão";
            this.ButtonConsultarSaldo.UseVisualStyleBackColor = true;
            this.ButtonConsultarSaldo.Click += new System.EventHandler(this.ButtonConsultarSaldo_Click);
            // 
            // ButtonConsultarCompras
            // 
            this.ButtonConsultarCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConsultarCompras.Location = new System.Drawing.Point(203, 216);
            this.ButtonConsultarCompras.Name = "ButtonConsultarCompras";
            this.ButtonConsultarCompras.Size = new System.Drawing.Size(217, 34);
            this.ButtonConsultarCompras.TabIndex = 17;
            this.ButtonConsultarCompras.Text = "Consultar compras de um cartão";
            this.ButtonConsultarCompras.UseVisualStyleBackColor = true;
            this.ButtonConsultarCompras.Click += new System.EventHandler(this.ButtonConsultarCompras_Click);
            // 
            // ButtonRegistarCompras
            // 
            this.ButtonRegistarCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRegistarCompras.Location = new System.Drawing.Point(203, 163);
            this.ButtonRegistarCompras.Name = "ButtonRegistarCompras";
            this.ButtonRegistarCompras.Size = new System.Drawing.Size(217, 34);
            this.ButtonRegistarCompras.TabIndex = 16;
            this.ButtonRegistarCompras.Text = "Registar compras";
            this.ButtonRegistarCompras.UseVisualStyleBackColor = true;
            this.ButtonRegistarCompras.Click += new System.EventHandler(this.ButtonRegistarCompras_Click);
            // 
            // ButtonAtribuirCartao
            // 
            this.ButtonAtribuirCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAtribuirCartao.Location = new System.Drawing.Point(203, 106);
            this.ButtonAtribuirCartao.Name = "ButtonAtribuirCartao";
            this.ButtonAtribuirCartao.Size = new System.Drawing.Size(217, 34);
            this.ButtonAtribuirCartao.TabIndex = 15;
            this.ButtonAtribuirCartao.Text = "Atribuir um cartão";
            this.ButtonAtribuirCartao.UseVisualStyleBackColor = true;
            this.ButtonAtribuirCartao.Click += new System.EventHandler(this.button1_Click);
            // 
            // GerirPontosDosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.ButtonGerirPontosVoltar);
            this.Controls.Add(this.ButtonConsultarSaldo);
            this.Controls.Add(this.ButtonConsultarCompras);
            this.Controls.Add(this.ButtonRegistarCompras);
            this.Controls.Add(this.ButtonAtribuirCartao);
            this.Name = "GerirPontosDosClientes";
            this.Text = "GerirPontosDosClientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonGerirPontosVoltar;
        private System.Windows.Forms.Button ButtonConsultarSaldo;
        private System.Windows.Forms.Button ButtonConsultarCompras;
        private System.Windows.Forms.Button ButtonRegistarCompras;
        private System.Windows.Forms.Button ButtonAtribuirCartao;
    }
}