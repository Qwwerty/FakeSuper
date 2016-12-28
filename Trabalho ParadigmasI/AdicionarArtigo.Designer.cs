namespace Trabalho_ParadigmasI
{
    partial class AdicionarArtigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarArtigo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAdicionarArtigoCodigo = new System.Windows.Forms.TextBox();
            this.TxtAdicionarArtigoPreco = new System.Windows.Forms.TextBox();
            this.TxtAdicionarArtigoStock = new System.Windows.Forms.TextBox();
            this.TxtAdicionarArtigoDescricao = new System.Windows.Forms.TextBox();
            this.ButtonConfirmarArtigoAdicionado = new System.Windows.Forms.Button();
            this.ButtonCancelarArtigoAdicionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do artigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço do artigo;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade em stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição do artigo:";
            // 
            // TxtAdicionarArtigoCodigo
            // 
            this.TxtAdicionarArtigoCodigo.Location = new System.Drawing.Point(148, 35);
            this.TxtAdicionarArtigoCodigo.Name = "TxtAdicionarArtigoCodigo";
            this.TxtAdicionarArtigoCodigo.Size = new System.Drawing.Size(100, 20);
            this.TxtAdicionarArtigoCodigo.TabIndex = 4;
            // 
            // TxtAdicionarArtigoPreco
            // 
            this.TxtAdicionarArtigoPreco.Location = new System.Drawing.Point(148, 68);
            this.TxtAdicionarArtigoPreco.Name = "TxtAdicionarArtigoPreco";
            this.TxtAdicionarArtigoPreco.Size = new System.Drawing.Size(100, 20);
            this.TxtAdicionarArtigoPreco.TabIndex = 5;
            // 
            // TxtAdicionarArtigoStock
            // 
            this.TxtAdicionarArtigoStock.Location = new System.Drawing.Point(148, 98);
            this.TxtAdicionarArtigoStock.Name = "TxtAdicionarArtigoStock";
            this.TxtAdicionarArtigoStock.Size = new System.Drawing.Size(100, 20);
            this.TxtAdicionarArtigoStock.TabIndex = 6;
            // 
            // TxtAdicionarArtigoDescricao
            // 
            this.TxtAdicionarArtigoDescricao.Location = new System.Drawing.Point(148, 134);
            this.TxtAdicionarArtigoDescricao.Multiline = true;
            this.TxtAdicionarArtigoDescricao.Name = "TxtAdicionarArtigoDescricao";
            this.TxtAdicionarArtigoDescricao.Size = new System.Drawing.Size(166, 118);
            this.TxtAdicionarArtigoDescricao.TabIndex = 7;
            // 
            // ButtonConfirmarArtigoAdicionado
            // 
            this.ButtonConfirmarArtigoAdicionado.Location = new System.Drawing.Point(115, 263);
            this.ButtonConfirmarArtigoAdicionado.Name = "ButtonConfirmarArtigoAdicionado";
            this.ButtonConfirmarArtigoAdicionado.Size = new System.Drawing.Size(124, 32);
            this.ButtonConfirmarArtigoAdicionado.TabIndex = 8;
            this.ButtonConfirmarArtigoAdicionado.Text = "Confirmar";
            this.ButtonConfirmarArtigoAdicionado.UseVisualStyleBackColor = true;
            this.ButtonConfirmarArtigoAdicionado.Click += new System.EventHandler(this.ButtonConfirmarArtigoAdicionado_Click);
            // 
            // ButtonCancelarArtigoAdicionado
            // 
            this.ButtonCancelarArtigoAdicionado.Location = new System.Drawing.Point(245, 263);
            this.ButtonCancelarArtigoAdicionado.Name = "ButtonCancelarArtigoAdicionado";
            this.ButtonCancelarArtigoAdicionado.Size = new System.Drawing.Size(124, 32);
            this.ButtonCancelarArtigoAdicionado.TabIndex = 9;
            this.ButtonCancelarArtigoAdicionado.Text = "Cancelar";
            this.ButtonCancelarArtigoAdicionado.UseVisualStyleBackColor = true;
            this.ButtonCancelarArtigoAdicionado.Click += new System.EventHandler(this.ButtonCancelarArtigoAdicionado_Click);
            // 
            // AdicionarArtigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 307);
            this.Controls.Add(this.ButtonCancelarArtigoAdicionado);
            this.Controls.Add(this.ButtonConfirmarArtigoAdicionado);
            this.Controls.Add(this.TxtAdicionarArtigoDescricao);
            this.Controls.Add(this.TxtAdicionarArtigoStock);
            this.Controls.Add(this.TxtAdicionarArtigoPreco);
            this.Controls.Add(this.TxtAdicionarArtigoCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdicionarArtigo";
            this.Text = "Adicionar Artigo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAdicionarArtigoCodigo;
        private System.Windows.Forms.TextBox TxtAdicionarArtigoPreco;
        private System.Windows.Forms.TextBox TxtAdicionarArtigoStock;
        private System.Windows.Forms.TextBox TxtAdicionarArtigoDescricao;
        private System.Windows.Forms.Button ButtonConfirmarArtigoAdicionado;
        private System.Windows.Forms.Button ButtonCancelarArtigoAdicionado;
    }
}