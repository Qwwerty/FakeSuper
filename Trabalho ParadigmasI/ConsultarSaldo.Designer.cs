namespace Trabalho_ParadigmasI
{
    partial class ConsultarSaldo
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
            this.ButtonVoltarConsultarArtigo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxConsultarArtigoNumeroCartao = new System.Windows.Forms.ComboBox();
            this.LabelValorGasto = new System.Windows.Forms.Label();
            this.LabelPontosAcumulados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonVoltarConsultarArtigo
            // 
            this.ButtonVoltarConsultarArtigo.Location = new System.Drawing.Point(133, 234);
            this.ButtonVoltarConsultarArtigo.Name = "ButtonVoltarConsultarArtigo";
            this.ButtonVoltarConsultarArtigo.Size = new System.Drawing.Size(124, 32);
            this.ButtonVoltarConsultarArtigo.TabIndex = 33;
            this.ButtonVoltarConsultarArtigo.Text = "Voltar";
            this.ButtonVoltarConsultarArtigo.UseVisualStyleBackColor = true;
            this.ButtonVoltarConsultarArtigo.Click += new System.EventHandler(this.ButtonVoltarConsultarArtigo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Pontos Acumulados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Valor total gasto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nº Cartão:";
            // 
            // ComboBoxConsultarArtigoNumeroCartao
            // 
            this.ComboBoxConsultarArtigoNumeroCartao.FormattingEnabled = true;
            this.ComboBoxConsultarArtigoNumeroCartao.Location = new System.Drawing.Point(157, 97);
            this.ComboBoxConsultarArtigoNumeroCartao.Name = "ComboBoxConsultarArtigoNumeroCartao";
            this.ComboBoxConsultarArtigoNumeroCartao.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxConsultarArtigoNumeroCartao.TabIndex = 34;
            // 
            // LabelValorGasto
            // 
            this.LabelValorGasto.AutoSize = true;
            this.LabelValorGasto.Location = new System.Drawing.Point(156, 130);
            this.LabelValorGasto.Name = "LabelValorGasto";
            this.LabelValorGasto.Size = new System.Drawing.Size(183, 13);
            this.LabelValorGasto.TabIndex = 35;
            this.LabelValorGasto.Text = "Progamar Para Escrever o total gasto";
            // 
            // LabelPontosAcumulados
            // 
            this.LabelPontosAcumulados.AutoSize = true;
            this.LabelPontosAcumulados.Location = new System.Drawing.Point(154, 163);
            this.LabelPontosAcumulados.Name = "LabelPontosAcumulados";
            this.LabelPontosAcumulados.Size = new System.Drawing.Size(229, 13);
            this.LabelPontosAcumulados.TabIndex = 36;
            this.LabelPontosAcumulados.Text = "Progamar para escrever os pontos acumulados";
            // 
            // ConsultarSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 307);
            this.Controls.Add(this.LabelPontosAcumulados);
            this.Controls.Add(this.LabelValorGasto);
            this.Controls.Add(this.ComboBoxConsultarArtigoNumeroCartao);
            this.Controls.Add(this.ButtonVoltarConsultarArtigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarSaldo";
            this.Text = "ConsultarSaldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonVoltarConsultarArtigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxConsultarArtigoNumeroCartao;
        private System.Windows.Forms.Label LabelValorGasto;
        private System.Windows.Forms.Label LabelPontosAcumulados;
    }
}