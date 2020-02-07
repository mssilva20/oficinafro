namespace tela1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btcad = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btcad
            // 
            this.btcad.Location = new System.Drawing.Point(142, 144);
            this.btcad.Name = "btcad";
            this.btcad.Size = new System.Drawing.Size(75, 23);
            this.btcad.TabIndex = 0;
            this.btcad.Text = "Cadastrar";
            this.btcad.UseVisualStyleBackColor = true;
            // 
            // txtnome
            // 
            this.txtnome.AutoSize = true;
            this.txtnome.Location = new System.Drawing.Point(54, 62);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(38, 13);
            this.txtnome.TabIndex = 1;
            this.txtnome.Text = "Nome:";
            this.txtnome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txttelefone
            // 
            this.txttelefone.AutoSize = true;
            this.txttelefone.Location = new System.Drawing.Point(54, 100);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(52, 13);
            this.txttelefone.TabIndex = 2;
            this.txttelefone.Text = "Telefone:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.btcad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcad;
        private System.Windows.Forms.Label txtnome;
        private System.Windows.Forms.Label txttelefone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

