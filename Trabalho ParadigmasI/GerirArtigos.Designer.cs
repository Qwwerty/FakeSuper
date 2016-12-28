namespace Trabalho_ParadigmasI
{
    partial class GerirArtigos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirArtigos));
            this.ButtonAdicionarArtigo = new System.Windows.Forms.Button();
            this.ButtonAtualizarStock = new System.Windows.Forms.Button();
            this.ButtonEliminarArtigo = new System.Windows.Forms.Button();
            this.ButtonVoltar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAdicionarArtigo
            // 
            this.ButtonAdicionarArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdicionarArtigo.Location = new System.Drawing.Point(367, 89);
            this.ButtonAdicionarArtigo.Name = "ButtonAdicionarArtigo";
            this.ButtonAdicionarArtigo.Size = new System.Drawing.Size(144, 37);
            this.ButtonAdicionarArtigo.TabIndex = 0;
            this.ButtonAdicionarArtigo.Text = "Adicionar Artigo";
            this.ButtonAdicionarArtigo.UseVisualStyleBackColor = true;
            this.ButtonAdicionarArtigo.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonAtualizarStock
            // 
            this.ButtonAtualizarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAtualizarStock.Location = new System.Drawing.Point(367, 157);
            this.ButtonAtualizarStock.Name = "ButtonAtualizarStock";
            this.ButtonAtualizarStock.Size = new System.Drawing.Size(144, 37);
            this.ButtonAtualizarStock.TabIndex = 1;
            this.ButtonAtualizarStock.Text = "Atualizar stock ";
            this.ButtonAtualizarStock.UseVisualStyleBackColor = true;
            this.ButtonAtualizarStock.Click += new System.EventHandler(this.ButtonAtualizarStock_Click);
            // 
            // ButtonEliminarArtigo
            // 
            this.ButtonEliminarArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEliminarArtigo.Location = new System.Drawing.Point(367, 227);
            this.ButtonEliminarArtigo.Name = "ButtonEliminarArtigo";
            this.ButtonEliminarArtigo.Size = new System.Drawing.Size(144, 37);
            this.ButtonEliminarArtigo.TabIndex = 2;
            this.ButtonEliminarArtigo.Text = "Eliminar artigo";
            this.ButtonEliminarArtigo.UseVisualStyleBackColor = true;
            this.ButtonEliminarArtigo.Click += new System.EventHandler(this.ButtonEliminarArtigo_Click);
            // 
            // ButtonVoltar
            // 
            this.ButtonVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVoltar.Location = new System.Drawing.Point(399, 306);
            this.ButtonVoltar.Name = "ButtonVoltar";
            this.ButtonVoltar.Size = new System.Drawing.Size(87, 31);
            this.ButtonVoltar.TabIndex = 3;
            this.ButtonVoltar.Text = "Voltar";
            this.ButtonVoltar.UseVisualStyleBackColor = true;
            this.ButtonVoltar.Click += new System.EventHandler(this.ButtonVoltar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(233, 334);
            this.dataGridView1.TabIndex = 4;
            // 
            // GerirArtigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonVoltar);
            this.Controls.Add(this.ButtonEliminarArtigo);
            this.Controls.Add(this.ButtonAtualizarStock);
            this.Controls.Add(this.ButtonAdicionarArtigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerirArtigos";
            this.Text = "GerirArtigos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAdicionarArtigo;
        private System.Windows.Forms.Button ButtonAtualizarStock;
        private System.Windows.Forms.Button ButtonEliminarArtigo;
        private System.Windows.Forms.Button ButtonVoltar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}