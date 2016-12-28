namespace Trabalho_ParadigmasI
{
    partial class RegistarCompras
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
            this.ButtonCancelarRegistarCompras = new System.Windows.Forms.Button();
            this.ButtonConfirmarRegistarCompras = new System.Windows.Forms.Button();
            this.TxtAdicionarArtigoStock = new System.Windows.Forms.TextBox();
            this.TxtRegistarComprasNCartao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxRegistarComprasProduto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ButtonCancelarRegistarCompras
            // 
            this.ButtonCancelarRegistarCompras.Location = new System.Drawing.Point(245, 263);
            this.ButtonCancelarRegistarCompras.Name = "ButtonCancelarRegistarCompras";
            this.ButtonCancelarRegistarCompras.Size = new System.Drawing.Size(124, 32);
            this.ButtonCancelarRegistarCompras.TabIndex = 33;
            this.ButtonCancelarRegistarCompras.Text = "Cancelar";
            this.ButtonCancelarRegistarCompras.UseVisualStyleBackColor = true;
            this.ButtonCancelarRegistarCompras.Click += new System.EventHandler(this.ButtonCancelarRegistarCompras_Click);
            // 
            // ButtonConfirmarRegistarCompras
            // 
            this.ButtonConfirmarRegistarCompras.Location = new System.Drawing.Point(115, 263);
            this.ButtonConfirmarRegistarCompras.Name = "ButtonConfirmarRegistarCompras";
            this.ButtonConfirmarRegistarCompras.Size = new System.Drawing.Size(124, 32);
            this.ButtonConfirmarRegistarCompras.TabIndex = 32;
            this.ButtonConfirmarRegistarCompras.Text = "Confirmar";
            this.ButtonConfirmarRegistarCompras.UseVisualStyleBackColor = true;
            // 
            // TxtAdicionarArtigoStock
            // 
            this.TxtAdicionarArtigoStock.Location = new System.Drawing.Point(150, 130);
            this.TxtAdicionarArtigoStock.Name = "TxtAdicionarArtigoStock";
            this.TxtAdicionarArtigoStock.Size = new System.Drawing.Size(164, 20);
            this.TxtAdicionarArtigoStock.TabIndex = 31;
            // 
            // TxtRegistarComprasNCartao
            // 
            this.TxtRegistarComprasNCartao.Location = new System.Drawing.Point(150, 70);
            this.TxtRegistarComprasNCartao.Name = "TxtRegistarComprasNCartao";
            this.TxtRegistarComprasNCartao.Size = new System.Drawing.Size(164, 20);
            this.TxtRegistarComprasNCartao.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "qq coisa aqui";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nº Cartão:";
            // 
            // ComboBoxRegistarComprasProduto
            // 
            this.ComboBoxRegistarComprasProduto.FormattingEnabled = true;
            this.ComboBoxRegistarComprasProduto.Location = new System.Drawing.Point(150, 100);
            this.ComboBoxRegistarComprasProduto.Name = "ComboBoxRegistarComprasProduto";
            this.ComboBoxRegistarComprasProduto.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxRegistarComprasProduto.TabIndex = 40;
            // 
            // RegistarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 307);
            this.Controls.Add(this.ComboBoxRegistarComprasProduto);
            this.Controls.Add(this.ButtonCancelarRegistarCompras);
            this.Controls.Add(this.ButtonConfirmarRegistarCompras);
            this.Controls.Add(this.TxtAdicionarArtigoStock);
            this.Controls.Add(this.TxtRegistarComprasNCartao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistarCompras";
            this.Text = "RegistarCompras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancelarRegistarCompras;
        private System.Windows.Forms.Button ButtonConfirmarRegistarCompras;
        private System.Windows.Forms.TextBox TxtAdicionarArtigoStock;
        private System.Windows.Forms.TextBox TxtRegistarComprasNCartao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxRegistarComprasProduto;
    }
}