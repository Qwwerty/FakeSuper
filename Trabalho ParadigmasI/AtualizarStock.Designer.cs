namespace Trabalho_ParadigmasI
{
    partial class AtualizarStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizarStock));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonAdicionarStock = new System.Windows.Forms.RadioButton();
            this.RadioButtonRemoverStock = new System.Windows.Forms.RadioButton();
            this.TxtAtualizarStockCodigo = new System.Windows.Forms.TextBox();
            this.TxtAtualizarStockQuantidadeAAlterar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonAtualizarStockConfirmar = new System.Windows.Forms.Button();
            this.ButtonAtualizarStockCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do artigo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonRemoverStock);
            this.groupBox1.Controls.Add(this.RadioButtonAdicionarStock);
            this.groupBox1.Location = new System.Drawing.Point(37, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar ou Remover stock";
            // 
            // RadioButtonAdicionarStock
            // 
            this.RadioButtonAdicionarStock.AutoSize = true;
            this.RadioButtonAdicionarStock.Location = new System.Drawing.Point(6, 19);
            this.RadioButtonAdicionarStock.Name = "RadioButtonAdicionarStock";
            this.RadioButtonAdicionarStock.Size = new System.Drawing.Size(69, 17);
            this.RadioButtonAdicionarStock.TabIndex = 2;
            this.RadioButtonAdicionarStock.TabStop = true;
            this.RadioButtonAdicionarStock.Text = "Adicionar";
            this.RadioButtonAdicionarStock.UseVisualStyleBackColor = true;
            // 
            // RadioButtonRemoverStock
            // 
            this.RadioButtonRemoverStock.AutoSize = true;
            this.RadioButtonRemoverStock.Location = new System.Drawing.Point(6, 42);
            this.RadioButtonRemoverStock.Name = "RadioButtonRemoverStock";
            this.RadioButtonRemoverStock.Size = new System.Drawing.Size(68, 17);
            this.RadioButtonRemoverStock.TabIndex = 3;
            this.RadioButtonRemoverStock.TabStop = true;
            this.RadioButtonRemoverStock.Text = "Remover";
            this.RadioButtonRemoverStock.UseVisualStyleBackColor = true;
            // 
            // TxtAtualizarStockCodigo
            // 
            this.TxtAtualizarStockCodigo.Location = new System.Drawing.Point(127, 45);
            this.TxtAtualizarStockCodigo.Name = "TxtAtualizarStockCodigo";
            this.TxtAtualizarStockCodigo.Size = new System.Drawing.Size(72, 20);
            this.TxtAtualizarStockCodigo.TabIndex = 1;
            // 
            // TxtAtualizarStockQuantidadeAAlterar
            // 
            this.TxtAtualizarStockQuantidadeAAlterar.Location = new System.Drawing.Point(147, 181);
            this.TxtAtualizarStockQuantidadeAAlterar.Name = "TxtAtualizarStockQuantidadeAAlterar";
            this.TxtAtualizarStockQuantidadeAAlterar.Size = new System.Drawing.Size(52, 20);
            this.TxtAtualizarStockQuantidadeAAlterar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade a alterar:";
            // 
            // ButtonAtualizarStockConfirmar
            // 
            this.ButtonAtualizarStockConfirmar.Location = new System.Drawing.Point(116, 226);
            this.ButtonAtualizarStockConfirmar.Name = "ButtonAtualizarStockConfirmar";
            this.ButtonAtualizarStockConfirmar.Size = new System.Drawing.Size(75, 23);
            this.ButtonAtualizarStockConfirmar.TabIndex = 5;
            this.ButtonAtualizarStockConfirmar.Text = "Confirmar";
            this.ButtonAtualizarStockConfirmar.UseVisualStyleBackColor = true;
            this.ButtonAtualizarStockConfirmar.Click += new System.EventHandler(this.ButtonAtualizarStockConfirmar_Click);
            // 
            // ButtonAtualizarStockCancelar
            // 
            this.ButtonAtualizarStockCancelar.Location = new System.Drawing.Point(197, 226);
            this.ButtonAtualizarStockCancelar.Name = "ButtonAtualizarStockCancelar";
            this.ButtonAtualizarStockCancelar.Size = new System.Drawing.Size(75, 23);
            this.ButtonAtualizarStockCancelar.TabIndex = 6;
            this.ButtonAtualizarStockCancelar.Text = "Cancelar";
            this.ButtonAtualizarStockCancelar.UseVisualStyleBackColor = true;
            this.ButtonAtualizarStockCancelar.Click += new System.EventHandler(this.ButtonAtualizarStockCancelar_Click);
            // 
            // AtualizarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ButtonAtualizarStockCancelar);
            this.Controls.Add(this.ButtonAtualizarStockConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAtualizarStockQuantidadeAAlterar);
            this.Controls.Add(this.TxtAtualizarStockCodigo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AtualizarStock";
            this.Text = "AtualizarStock";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtAtualizarStockQuantidadeAAlterar;
        private System.Windows.Forms.RadioButton RadioButtonRemoverStock;
        private System.Windows.Forms.RadioButton RadioButtonAdicionarStock;
        private System.Windows.Forms.TextBox TxtAtualizarStockCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonAtualizarStockConfirmar;
        private System.Windows.Forms.Button ButtonAtualizarStockCancelar;
    }
}